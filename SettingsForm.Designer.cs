﻿namespace NGUIndustriesInjector
{
    partial class SettingsForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UnloadSafety = new System.Windows.Forms.CheckBox();
            this.UnloadButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.PitThresholdSave = new System.Windows.Forms.Button();
            this.PitThreshold = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MasterEnable = new System.Windows.Forms.CheckBox();
            this.AutoPit = new System.Windows.Forms.CheckBox();
            this.AutoDailySpin = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(598, 13);
            this.progressBar1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.progressBar1);
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 387);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 360);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UnloadSafety);
            this.tabPage1.Controls.Add(this.UnloadButton);
            this.tabPage1.Controls.Add(this.VersionLabel);
            this.tabPage1.Controls.Add(this.PitThresholdSave);
            this.tabPage1.Controls.Add(this.PitThreshold);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.MasterEnable);
            this.tabPage1.Controls.Add(this.AutoPit);
            this.tabPage1.Controls.Add(this.AutoDailySpin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UnloadSafety
            // 
            this.UnloadSafety.AutoSize = true;
            this.UnloadSafety.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UnloadSafety.Location = new System.Drawing.Point(396, 308);
            this.UnloadSafety.Name = "UnloadSafety";
            this.UnloadSafety.Size = new System.Drawing.Size(15, 14);
            this.UnloadSafety.TabIndex = 17;
            this.UnloadSafety.UseVisualStyleBackColor = true;
            this.UnloadSafety.CheckedChanged += new System.EventHandler(this.UnloadSafety_CheckedChanged);
            // 
            // UnloadButton
            // 
            this.UnloadButton.Enabled = false;
            this.UnloadButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UnloadButton.Location = new System.Drawing.Point(417, 303);
            this.UnloadButton.Name = "UnloadButton";
            this.UnloadButton.Size = new System.Drawing.Size(75, 23);
            this.UnloadButton.TabIndex = 16;
            this.UnloadButton.Text = "Unload";
            this.UnloadButton.UseVisualStyleBackColor = true;
            this.UnloadButton.Click += new System.EventHandler(this.UnloadButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VersionLabel.Location = new System.Drawing.Point(498, 308);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(81, 13);
            this.VersionLabel.TabIndex = 15;
            this.VersionLabel.Text = "Version: 2.2.0.0";
            // 
            // PitThresholdSave
            // 
            this.PitThresholdSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PitThresholdSave.Location = new System.Drawing.Point(243, 147);
            this.PitThresholdSave.Name = "PitThresholdSave";
            this.PitThresholdSave.Size = new System.Drawing.Size(76, 20);
            this.PitThresholdSave.TabIndex = 12;
            this.PitThresholdSave.Text = "Save";
            this.PitThresholdSave.UseVisualStyleBackColor = true;
            this.PitThresholdSave.Visible = false;
            this.PitThresholdSave.Click += new System.EventHandler(this.MoneyPitThresholdSave_Click);
            // 
            // PitThreshold
            // 
            this.PitThreshold.Location = new System.Drawing.Point(113, 147);
            this.PitThreshold.Name = "PitThreshold";
            this.PitThreshold.Size = new System.Drawing.Size(124, 20);
            this.PitThreshold.TabIndex = 11;
            this.PitThreshold.Visible = false;
            this.PitThreshold.TextChanged += new System.EventHandler(this.MoneyPitThreshold_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pit Threshold";
            this.label7.Visible = false;
            // 
            // MasterEnable
            // 
            this.MasterEnable.AutoSize = true;
            this.MasterEnable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MasterEnable.Location = new System.Drawing.Point(6, 6);
            this.MasterEnable.Name = "MasterEnable";
            this.MasterEnable.Size = new System.Drawing.Size(93, 17);
            this.MasterEnable.TabIndex = 4;
            this.MasterEnable.Text = "Master Switch";
            this.MasterEnable.UseVisualStyleBackColor = true;
            this.MasterEnable.CheckedChanged += new System.EventHandler(this.MasterEnable_CheckedChanged);
            // 
            // AutoPit
            // 
            this.AutoPit.AutoSize = true;
            this.AutoPit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoPit.Location = new System.Drawing.Point(5, 130);
            this.AutoPit.Name = "AutoPit";
            this.AutoPit.Size = new System.Drawing.Size(63, 17);
            this.AutoPit.TabIndex = 6;
            this.AutoPit.Text = "Auto Pit";
            this.AutoPit.UseVisualStyleBackColor = true;
            this.AutoPit.Visible = false;
            this.AutoPit.CheckedChanged += new System.EventHandler(this.AutoMoneyPit_CheckedChanged);
            // 
            // AutoDailySpin
            // 
            this.AutoDailySpin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AutoDailySpin.Location = new System.Drawing.Point(6, 29);
            this.AutoDailySpin.Name = "AutoDailySpin";
            this.AutoDailySpin.Size = new System.Drawing.Size(98, 17);
            this.AutoDailySpin.TabIndex = 5;
            this.AutoDailySpin.Text = "Auto Daily Spin";
            this.AutoDailySpin.UseVisualStyleBackColor = true;
            this.AutoDailySpin.CheckedChanged += new System.EventHandler(this.AutoDailySpin_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Factories";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 387);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "NGU INDUSTRIES Injector Settings";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox UnloadSafety;
        private System.Windows.Forms.Button UnloadButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button PitThresholdSave;
        private System.Windows.Forms.TextBox PitThreshold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox MasterEnable;
        private System.Windows.Forms.CheckBox AutoPit;
        private System.Windows.Forms.CheckBox AutoDailySpin;
        private System.Windows.Forms.TabPage tabPage2;
    }
}