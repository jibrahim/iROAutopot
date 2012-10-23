using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace iRO_Autopot
{
    public partial class AutoPotterForm : Form
    {
        private Logic logic;
        System.Windows.Forms.Timer logicTimer;


        public AutoPotterForm()
        {
            logic = new Logic();

            InitializeComponent();
            this.FormClosing += CloseWindow;

            comboHpKey.SelectedIndex = 0;
            comboSpKey.SelectedIndex = 0;

            logicTimer = new System.Windows.Forms.Timer();
            logicTimer.Tick += Looper;
            logicTimer.Interval = (int)((1.0 / 60.0) * 1000.0);
            logicTimer.Start();
        }

        private void Looper(object sender, EventArgs e)
        {
            try
            {
                logic.Update();
            }
            catch (ProcessNotFoundException)
            {
                this.labelName.Text = "Name";
                this.labelHp.Text = "-/-";
                this.labelSP.Text = "-/-";
                this.labelMapName.Text = "Map";
                try
                {
                    logic.AttachToProcess();
                    this.Text = "iRO AutoPot - Engaged";
                }
                catch (ProcessNotFoundException) 
                {
                    logic.Dispose();
                    this.Text = "iRO AutoPot - Disengaged";
                }
                return;
            }
            catch (Exception ex)
            {
                if (!this.checkSuppress.Checked)
                {
                    logicTimer.Stop();
                    MessageBox.Show("An error has occured\n" + ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
                logic.Dispose();
                this.Text = "iRO AutoPot - Disengaged";
                return;
            }
            this.labelName.Text = logic.Name;
            this.labelHp.Text = logic.CurrentHp + "/" + logic.MaxHp;
            this.labelSP.Text = logic.CurrentSp + "/" + logic.MaxSp;
            this.labelMapName.Text = logic.MapName;
        }

        private void nudHp_ValueChanged(object sender, EventArgs e)
        {
            logic.PercentHp = (int)nudHp.Value;
        }

        private void nudSp_ValueChanged(object sender, EventArgs e)
        {
            logic.PercentSp = (int)nudSp.Value;
        }

        private void comboHpKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.HpKey = comboHpKey.SelectedIndex;
        }

        private void comboSpKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.SpKey = comboSpKey.SelectedIndex;
        }

        private void checkHp_CheckedChanged(object sender, EventArgs e)
        {
            logic.HpEnabled = checkHp.Checked;
        }

        private void checkSp_CheckedChanged(object sender, EventArgs e)
        {
            logic.SpEnabled = checkSp.Checked;
        }

        private void CloseWindow()
        {
            logic.Dispose();
        }

        private void CloseWindow(object s, EventArgs e)
        {
            CloseWindow();
        }

        private void checkSpEmergency_CheckedChanged(object sender, EventArgs e)
        {
            logic.SpEmergencyEnabled = checkSpEmergency.Checked;
        }

        private void nudSpEmergency_ValueChanged(object sender, EventArgs e)
        {
            logic.EmergencySp = (int)nudSpEmergency.Value;
        }

        private void checkLockHp_CheckedChanged(object sender, EventArgs e)
        {
            logic.LockMaxHp = checkLockHp.Checked;
            logic.LockMaxHpValue();
        }

        private void checkLockSp_CheckedChanged(object sender, EventArgs e)
        {
            logic.LockMaxSp = checkLockSp.Checked;
            logic.LockMaxSpValue();
        }

        private void checkWoEOnly_CheckedChanged(object sender, EventArgs e)
        {
            logic.WoeOnly = checkWoEOnly.Checked;
        }

        private void checkUpdateLock_CheckedChanged(object sender, EventArgs e)
        {
            logic.UpdateOnPot = checkUpdateLock.Checked;
        }

        private void checkPottingDelay_CheckedChanged(object sender, EventArgs e)
        {
            logic.DelayPotting = checkPottingDelay.Checked;
        }

        private void nudFrameDelay_ValueChanged(object sender, EventArgs e)
        {
            logic.DelayPottingFrames = (int)nudFrameDelay.Value;
        }

        private void nudIgnoreDelay_ValueChanged(object sender, EventArgs e)
        {
            logic.EmergencyHp = (int)nudIgnoreDelay.Value;
        }
    }
}
