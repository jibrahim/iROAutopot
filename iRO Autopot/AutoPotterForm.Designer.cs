namespace iRO_Autopot
{
    partial class AutoPotterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoPotterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelHp = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSP = new System.Windows.Forms.Label();
            this.comboHpKey = new System.Windows.Forms.ComboBox();
            this.comboSpKey = new System.Windows.Forms.ComboBox();
            this.nudHp = new System.Windows.Forms.NumericUpDown();
            this.nudSp = new System.Windows.Forms.NumericUpDown();
            this.checkHp = new System.Windows.Forms.CheckBox();
            this.checkSp = new System.Windows.Forms.CheckBox();
            this.nudSpEmergency = new System.Windows.Forms.NumericUpDown();
            this.checkSpEmergency = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkLockHp = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkLockSp = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFrameDelay = new System.Windows.Forms.NumericUpDown();
            this.checkPottingDelay = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkUpdateLock = new System.Windows.Forms.CheckBox();
            this.nudIgnoreDelay = new System.Windows.Forms.NumericUpDown();
            this.checkIgnoreDelay = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkWoEOnly = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMapName = new System.Windows.Forms.Label();
            this.checkSuppress = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpEmergency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIgnoreDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HP:";
            // 
            // labelHp
            // 
            this.labelHp.AutoSize = true;
            this.labelHp.Location = new System.Drawing.Point(43, 45);
            this.labelHp.Name = "labelHp";
            this.labelHp.Size = new System.Drawing.Size(18, 13);
            this.labelHp.TabIndex = 2;
            this.labelHp.Text = "-/-";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SP:";
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Location = new System.Drawing.Point(43, 72);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(18, 13);
            this.labelSP.TabIndex = 5;
            this.labelSP.Text = "-/-";
            // 
            // comboHpKey
            // 
            this.comboHpKey.FormattingEnabled = true;
            this.comboHpKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            ",",
            "."});
            this.comboHpKey.Location = new System.Drawing.Point(218, 42);
            this.comboHpKey.Name = "comboHpKey";
            this.comboHpKey.Size = new System.Drawing.Size(53, 21);
            this.comboHpKey.TabIndex = 6;
            this.comboHpKey.SelectedIndexChanged += new System.EventHandler(this.comboHpKey_SelectedIndexChanged);
            // 
            // comboSpKey
            // 
            this.comboSpKey.FormattingEnabled = true;
            this.comboSpKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            ",",
            "."});
            this.comboSpKey.Location = new System.Drawing.Point(218, 69);
            this.comboSpKey.Name = "comboSpKey";
            this.comboSpKey.Size = new System.Drawing.Size(53, 21);
            this.comboSpKey.TabIndex = 7;
            this.comboSpKey.SelectedIndexChanged += new System.EventHandler(this.comboSpKey_SelectedIndexChanged);
            // 
            // nudHp
            // 
            this.nudHp.Location = new System.Drawing.Point(162, 43);
            this.nudHp.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudHp.Name = "nudHp";
            this.nudHp.Size = new System.Drawing.Size(50, 20);
            this.nudHp.TabIndex = 8;
            this.nudHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHp.ValueChanged += new System.EventHandler(this.nudHp_ValueChanged);
            // 
            // nudSp
            // 
            this.nudSp.Location = new System.Drawing.Point(162, 69);
            this.nudSp.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudSp.Name = "nudSp";
            this.nudSp.Size = new System.Drawing.Size(50, 20);
            this.nudSp.TabIndex = 9;
            this.nudSp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSp.ValueChanged += new System.EventHandler(this.nudSp_ValueChanged);
            // 
            // checkHp
            // 
            this.checkHp.AutoSize = true;
            this.checkHp.Location = new System.Drawing.Point(277, 45);
            this.checkHp.Name = "checkHp";
            this.checkHp.Size = new System.Drawing.Size(15, 14);
            this.checkHp.TabIndex = 10;
            this.checkHp.UseVisualStyleBackColor = true;
            this.checkHp.CheckedChanged += new System.EventHandler(this.checkHp_CheckedChanged);
            // 
            // checkSp
            // 
            this.checkSp.AutoSize = true;
            this.checkSp.Location = new System.Drawing.Point(277, 71);
            this.checkSp.Name = "checkSp";
            this.checkSp.Size = new System.Drawing.Size(15, 14);
            this.checkSp.TabIndex = 11;
            this.checkSp.UseVisualStyleBackColor = true;
            this.checkSp.CheckedChanged += new System.EventHandler(this.checkSp_CheckedChanged);
            // 
            // nudSpEmergency
            // 
            this.nudSpEmergency.Location = new System.Drawing.Point(162, 95);
            this.nudSpEmergency.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudSpEmergency.Name = "nudSpEmergency";
            this.nudSpEmergency.Size = new System.Drawing.Size(50, 20);
            this.nudSpEmergency.TabIndex = 12;
            this.nudSpEmergency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSpEmergency.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudSpEmergency.ValueChanged += new System.EventHandler(this.nudSpEmergency_ValueChanged);
            // 
            // checkSpEmergency
            // 
            this.checkSpEmergency.AutoSize = true;
            this.checkSpEmergency.Location = new System.Drawing.Point(277, 97);
            this.checkSpEmergency.Name = "checkSpEmergency";
            this.checkSpEmergency.Size = new System.Drawing.Size(15, 14);
            this.checkSpEmergency.TabIndex = 13;
            this.checkSpEmergency.UseVisualStyleBackColor = true;
            this.checkSpEmergency.CheckedChanged += new System.EventHandler(this.checkSpEmergency_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Minimum SP";
            // 
            // checkLockHp
            // 
            this.checkLockHp.AutoSize = true;
            this.checkLockHp.Location = new System.Drawing.Point(277, 123);
            this.checkLockHp.Name = "checkLockHp";
            this.checkLockHp.Size = new System.Drawing.Size(15, 14);
            this.checkLockHp.TabIndex = 15;
            this.checkLockHp.UseVisualStyleBackColor = true;
            this.checkLockHp.CheckedChanged += new System.EventHandler(this.checkLockHp_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lock MaxHP";
            // 
            // checkLockSp
            // 
            this.checkLockSp.AutoSize = true;
            this.checkLockSp.Location = new System.Drawing.Point(277, 149);
            this.checkLockSp.Name = "checkLockSp";
            this.checkLockSp.Size = new System.Drawing.Size(15, 14);
            this.checkLockSp.TabIndex = 19;
            this.checkLockSp.UseVisualStyleBackColor = true;
            this.checkLockSp.CheckedChanged += new System.EventHandler(this.checkLockSp_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Lock MaxSP";
            // 
            // nudFrameDelay
            // 
            this.nudFrameDelay.Location = new System.Drawing.Point(162, 173);
            this.nudFrameDelay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudFrameDelay.Name = "nudFrameDelay";
            this.nudFrameDelay.Size = new System.Drawing.Size(50, 20);
            this.nudFrameDelay.TabIndex = 21;
            this.nudFrameDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFrameDelay.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudFrameDelay.ValueChanged += new System.EventHandler(this.nudFrameDelay_ValueChanged);
            // 
            // checkPottingDelay
            // 
            this.checkPottingDelay.AutoSize = true;
            this.checkPottingDelay.Location = new System.Drawing.Point(277, 175);
            this.checkPottingDelay.Name = "checkPottingDelay";
            this.checkPottingDelay.Size = new System.Drawing.Size(15, 14);
            this.checkPottingDelay.TabIndex = 22;
            this.checkPottingDelay.UseVisualStyleBackColor = true;
            this.checkPottingDelay.CheckedChanged += new System.EventHandler(this.checkPottingDelay_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Potting Frame Delay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Update locked max hp/sp when manually potted";
            // 
            // checkUpdateLock
            // 
            this.checkUpdateLock.AutoSize = true;
            this.checkUpdateLock.Location = new System.Drawing.Point(277, 252);
            this.checkUpdateLock.Name = "checkUpdateLock";
            this.checkUpdateLock.Size = new System.Drawing.Size(15, 14);
            this.checkUpdateLock.TabIndex = 26;
            this.checkUpdateLock.UseVisualStyleBackColor = true;
            this.checkUpdateLock.CheckedChanged += new System.EventHandler(this.checkUpdateLock_CheckedChanged);
            // 
            // nudIgnoreDelay
            // 
            this.nudIgnoreDelay.Location = new System.Drawing.Point(162, 199);
            this.nudIgnoreDelay.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudIgnoreDelay.Name = "nudIgnoreDelay";
            this.nudIgnoreDelay.Size = new System.Drawing.Size(50, 20);
            this.nudIgnoreDelay.TabIndex = 27;
            this.nudIgnoreDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIgnoreDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIgnoreDelay.ValueChanged += new System.EventHandler(this.nudIgnoreDelay_ValueChanged);
            // 
            // checkIgnoreDelay
            // 
            this.checkIgnoreDelay.AutoSize = true;
            this.checkIgnoreDelay.Location = new System.Drawing.Point(277, 201);
            this.checkIgnoreDelay.Name = "checkIgnoreDelay";
            this.checkIgnoreDelay.Size = new System.Drawing.Size(15, 14);
            this.checkIgnoreDelay.TabIndex = 28;
            this.checkIgnoreDelay.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ignore Delay on HP%";
            // 
            // checkWoEOnly
            // 
            this.checkWoEOnly.AutoSize = true;
            this.checkWoEOnly.Location = new System.Drawing.Point(277, 227);
            this.checkWoEOnly.Name = "checkWoEOnly";
            this.checkWoEOnly.Size = new System.Drawing.Size(15, 14);
            this.checkWoEOnly.TabIndex = 31;
            this.checkWoEOnly.UseVisualStyleBackColor = true;
            this.checkWoEOnly.CheckedChanged += new System.EventHandler(this.checkWoEOnly_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "WoE Only";
            // 
            // labelMapName
            // 
            this.labelMapName.AutoSize = true;
            this.labelMapName.Location = new System.Drawing.Point(162, 12);
            this.labelMapName.Name = "labelMapName";
            this.labelMapName.Size = new System.Drawing.Size(28, 13);
            this.labelMapName.TabIndex = 33;
            this.labelMapName.Text = "Map";
            // 
            // checkSuppress
            // 
            this.checkSuppress.AutoSize = true;
            this.checkSuppress.Location = new System.Drawing.Point(277, 311);
            this.checkSuppress.Name = "checkSuppress";
            this.checkSuppress.Size = new System.Drawing.Size(15, 14);
            this.checkSuppress.TabIndex = 34;
            this.checkSuppress.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Suppress Exceptions";
            // 
            // AutoPotterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 337);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkSuppress);
            this.Controls.Add(this.labelMapName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkWoEOnly);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkIgnoreDelay);
            this.Controls.Add(this.nudIgnoreDelay);
            this.Controls.Add(this.checkUpdateLock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkPottingDelay);
            this.Controls.Add(this.nudFrameDelay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkLockSp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkLockHp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkSpEmergency);
            this.Controls.Add(this.nudSpEmergency);
            this.Controls.Add(this.checkSp);
            this.Controls.Add(this.checkHp);
            this.Controls.Add(this.nudSp);
            this.Controls.Add(this.nudHp);
            this.Controls.Add(this.comboSpKey);
            this.Controls.Add(this.comboHpKey);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelHp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoPotterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "iRO Auto Pot";
            ((System.ComponentModel.ISupportInitialize)(this.nudHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpEmergency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIgnoreDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHp;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.ComboBox comboHpKey;
        private System.Windows.Forms.ComboBox comboSpKey;
        private System.Windows.Forms.NumericUpDown nudHp;
        private System.Windows.Forms.NumericUpDown nudSp;
        private System.Windows.Forms.CheckBox checkHp;
        private System.Windows.Forms.CheckBox checkSp;
        private System.Windows.Forms.NumericUpDown nudSpEmergency;
        private System.Windows.Forms.CheckBox checkSpEmergency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkLockHp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkLockSp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFrameDelay;
        private System.Windows.Forms.CheckBox checkPottingDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkUpdateLock;
        private System.Windows.Forms.NumericUpDown nudIgnoreDelay;
        private System.Windows.Forms.CheckBox checkIgnoreDelay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkWoEOnly;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMapName;
        private System.Windows.Forms.CheckBox checkSuppress;
        private System.Windows.Forms.Label label10;
    }
}

