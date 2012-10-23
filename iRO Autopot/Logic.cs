using System;
using System.Collections.Generic;
using System.Text;
using ReadWriteMemory;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DirectInputEmulation;
using System.Net;
using System.Net.Mail;

namespace iRO_Autopot
{
    class Logic
    {
        private const int HP = 0x008B78DC;
        private const int SP = 0x008B78E4;
        private const int MAX_HP = 0x008B78E0;
        private const int MAX_SP = 0x008B78E8;
        private const int NAME = 0x008b7bf8;
        private const int MAP_NAME = 0x008b57a4;
        private const int MAP_NAME_SIZE = 10;
        private const int MAX_LEN = 24;
        private const int MIN_LEN = 4;
        private const int MAX_MAP_NAME_LEN = 10;

        private int currentHp;
        private int currentSp;
        private int maxHp;
        private int maxSp;
        private string name;

        private int percentHp;
        private int percentSp;
        private int emergencySp;
        private int emergencyHp;

        private ProcessMemory memory;

        private int hpKey;
        private int spKey;
        private int maxHpLock;
        private int maxSpLock;
        private int delayPottingFrames;
        private int currentPottingFrame;

        private bool hpEnabled;
        private bool spEnabled;
        private bool spEmergencyEnabled;
        private bool lockMaxHp;
        private bool lockMaxSp;
        private bool woeOnly;
        private bool updateOnPot;
        private bool delayPotting;
        private bool onWoeMap;

        private string mapName;

        public int CurrentHp { get { return currentHp; } }
        public int CurrentSp { get { return currentSp; } }
        public int MaxHp { get { return maxHp; } }
        public int MaxSp { get { return maxSp; } }
        public int DelayPottingFrames { get { return delayPottingFrames; } set { delayPottingFrames = value; } }
        public string Name { get { return name; } }

        public int PercentHp { get { return percentHp; } set { percentHp = value; } }
        public int PercentSp { get { return percentSp; } set { percentSp = value; } }
        public int EmergencySp { get { return emergencySp; } set { emergencySp = value; } }
        public int EmergencyHp { get { return emergencyHp; } set { emergencyHp = value; } }

        public int HpKey { get { return hpKey; } set { hpKey = value; } }
        public int SpKey { get { return spKey; } set { spKey = value; } }

        public bool HpEnabled { get { return hpEnabled; } set { hpEnabled = value; } }
        public bool SpEnabled { get { return spEnabled; } set { spEnabled = value; } }
        public bool SpEmergencyEnabled { get { return spEmergencyEnabled; } set { spEmergencyEnabled = value; } }
        public bool WoeOnly { get { return woeOnly; } set { woeOnly = value; } }
        public bool UpdateOnPot { get { return updateOnPot; } set { updateOnPot = value; } }
        public bool DelayPotting { get { return delayPotting; } set { delayPotting = value; } }
        public string MapName { get { return mapName; } set { mapName = value; } }

        public bool LockMaxHp 
        { 
            get 
            { 
                return lockMaxHp;
            } 
            set 
            { 
                lockMaxHp = value;
                if (value)
                {
                    this.maxHpLock = this.maxHp;
                }
            } 
        }

        public bool LockMaxSp 
        { 
            get 
            { 
                return lockMaxSp; 
            } 
            set 
            { 
                lockMaxSp = value;
                if (value)
                    this.maxSpLock = this.maxSp;
            } 
        }

        private bool hpKeyTrigger;
        private bool spKeyTrigger;

        private Key[] keyMap = { Key.A, Key.B, Key.C, Key.D, Key.E, Key.F, Key.G, Key.H, Key.I, Key.J, Key.K,
                                   Key.L, Key.M, Key.N, Key.O, Key.P, Key.Q, Key.R, Key.S, Key.T, Key.U, Key.V,
                                   Key.W, Key.X, Key.Y, Key.Z, Key.F1, Key.F2, Key.F3, Key.F4, Key.F5, Key.F6,
                                   Key.F7, Key.F8, Key.F9, Key.Comma, Key.Period };

        private String[] mapNames = { "gefg_cas01", "gefg_cas02", "gefg_cas03", "gefg_cas04", "gefg_case05",
                                      "payg_cas01", "payg_cas02", "payg_cas03", "payg_cas04", "payg_cas05",
                                      "aldeg_cas01", "aldeg_cas02", "aldeg_cas03", "aldeg_cas04", "aldeg_cas05",
                                      "prtg_cas01", "prtg_cas02", "prtg_cas03", "prtg_cas04", "prtg_cas05"};

        public Logic()
        {            
        }

        public void AttachToProcess()
        {
            memory = new ProcessMemory(@"clragexe");
            if (!memory.CheckProcess())
                throw new ProcessNotFoundException("Process not found.");
            memory.StartProcess();
        }

        public void Update()
        {
            if (memory == null)
                throw new ProcessNotFoundException("Never attached");
            if (!memory.CheckProcess())
                throw new ProcessNotFoundException("Process not found.");
            this.name = memory.ReadStringAscii(NAME, MAX_LEN);
            UpdateHpSp();
            DetermineMapChange();

            string title = WindowsAPI.GetActiveWindowTitle();
            if (!String.IsNullOrEmpty(title) && title.Equals("Ragnarok") && ((onWoeMap && woeOnly) || !woeOnly))
            {
                currentPottingFrame++;
                PottingArray ary = DeterminePotting();
                if (ary.emergencySp || spKeyTrigger)
                {
                    if (spKeyTrigger)
                        DirectInputEmulator.Send_Key((short)keyMap[spKey], DirectInputEmulator.KEYEVENTF_KEYUP | DirectInputEmulation.DirectInputEmulator.KEYEVENTF_SCANCODE);
                    else
                        DirectInputEmulator.Send_Key((short)keyMap[spKey], DirectInputEmulator.KEYEVENTF_SCANCODE);
                    spKeyTrigger = !spKeyTrigger;
                }
                else if (ary.allowHp || hpKeyTrigger)
                {
                    if (hpKeyTrigger)
                        DirectInputEmulator.Send_Key((short)keyMap[hpKey], DirectInputEmulator.KEYEVENTF_KEYUP | DirectInputEmulation.DirectInputEmulator.KEYEVENTF_SCANCODE);
                    else
                        DirectInputEmulator.Send_Key((short)keyMap[hpKey], DirectInputEmulator.KEYEVENTF_SCANCODE);
                    hpKeyTrigger = !hpKeyTrigger;
                }
                else if (ary.allowSp || spKeyTrigger)
                {
                    if (spKeyTrigger)
                        DirectInputEmulator.Send_Key((short)keyMap[spKey], DirectInputEmulator.KEYEVENTF_KEYUP | DirectInputEmulation.DirectInputEmulator.KEYEVENTF_SCANCODE);
                    else
                        DirectInputEmulator.Send_Key((short)keyMap[spKey], DirectInputEmulator.KEYEVENTF_SCANCODE);
                    spKeyTrigger = !spKeyTrigger;
                }
            }
        }

        public void Dispose()
        {
            try
            {
                ReadWriteMemory.ProcessMemory.CloseHandle(memory.ProcessHandle);
                memory = null;
            }
            catch { }
        }

        private void UpdateHpSp()
        {
            if (lockMaxHp)
                this.maxHp = (memory.ReadInt(MAX_HP) > maxHpLock) ? maxHpLock : memory.ReadInt(MAX_HP);
            else
                this.maxHp = memory.ReadInt(MAX_HP);
            if (lockMaxSp)
                this.maxSp = (memory.ReadInt(MAX_SP) > maxSpLock) ? maxSpLock : memory.ReadInt(MAX_SP);
            else
                this.maxSp = memory.ReadInt(MAX_SP);
            this.currentSp = memory.ReadInt(SP);
            this.currentHp = memory.ReadInt(HP);


            if (this.currentHp > this.maxHp)
                this.maxHp = this.currentHp;
            if (this.currentSp > this.maxSp)
                this.maxSp = this.currentSp;
        }

        private PottingArray DeterminePotting()
        {
            PottingArray ary;
            ary.allowHp = false;
            ary.allowSp = false;
            ary.emergencySp = false;
            int hpPercent;
            int spPercent;
            try
            {
                hpPercent = this.currentHp * 100 / this.maxHp;
                spPercent = this.currentSp * 100 / this.maxSp;
            }
            catch (DivideByZeroException)
            {
                return ary;
            }

            if (this.SpEmergencyEnabled && this.currentSp < this.emergencySp)
                ary.emergencySp = true;
            if (hpPercent <= this.percentHp)
                ary.allowHp = true;
            if (spPercent <= this.percentSp)
                ary.allowSp = true;

            if (delayPotting && currentPottingFrame <= DelayPottingFrames)
            {
                ary.allowHp = ary.allowSp = false;
                if (hpPercent <= emergencyHp)
                    ary.allowHp = true;
            }

            if (woeOnly && !onWoeMap)
            {
                ary.allowHp = ary.allowSp = false;
                if (hpPercent <= emergencyHp)
                    ary.allowHp = true;
            }

            if ((hpPercent > this.percentHp || !hpEnabled) && (spPercent > this.percentSp || !spEnabled) && (this.currentSp > this.emergencySp || !spEmergencyEnabled))
                this.currentPottingFrame = 0;

            return ary;
        }

        public void DetermineMapChange()
        {
            string map = memory.ReadStringAscii(MAP_NAME, MAX_MAP_NAME_LEN);
            if (String.IsNullOrEmpty(this.mapName))
                this.mapName = map;
            else if (this.mapName.Equals(map))
                return;
            else
                this.mapName = map;
            onWoeMap = false;
            foreach (string s in mapNames)
            {
                if (s.Equals(mapName))
                {
                    onWoeMap = true;
                    break;
                }
            }
        }

        public void LockMaxHpValue()
        {
            if (lockMaxHp)
                this.maxHpLock = this.MaxHp;
        }

        public void LockMaxSpValue()
        {
            if (lockMaxSp)
                this.maxSpLock = this.MaxSp;
        }
    }

    public struct PottingArray
    {
        public bool allowHp;
        public bool allowSp;
        public bool emergencySp;
    }

    public enum Key
    {
        Q = 16,
        W = 17,
        E = 18,
        R = 19,
        T = 20,
        Y = 21,
        U = 22,
        I = 23,
        O = 24,
        P = 25,
        A = 30,
        S = 31,
        D = 32,
        F = 33,
        G = 34,
        H = 35,
        J = 36,
        K = 37,
        L = 38,
        Z = 44,
        X = 45,
        C = 46,
        V = 47,
        B = 48,
        N = 49,
        M = 50,
        Comma = 51,
        Period = 52,
        F1 = 59,
        F2 = 60,
        F3 = 61,
        F4 = 62,
        F5 = 63,
        F6 = 64,
        F7 = 65,
        F8 = 66,
        F9 = 67,
    }

    public class ProcessNotFoundException : Exception
    {
        public ProcessNotFoundException() : base() { }
        public ProcessNotFoundException(string message) : base(message) {}
    }
}
