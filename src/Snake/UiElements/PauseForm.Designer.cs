namespace Snake.UiElements
{
    partial class PauseForm
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
            this.BtnContinue = new System.Windows.Forms.Button();
            this.LabelPause = new System.Windows.Forms.Label();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnContinue
            // 
            this.BtnContinue.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnContinue.FlatAppearance.BorderSize = 0;
            this.BtnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(124)))), ((int)(((byte)(235)))));
            this.BtnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinue.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnContinue.ForeColor = System.Drawing.Color.White;
            this.BtnContinue.Image = global::Snake.Properties.Resources.Play;
            this.BtnContinue.Location = new System.Drawing.Point(11, 81);
            this.BtnContinue.Margin = new System.Windows.Forms.Padding(2);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnContinue.Size = new System.Drawing.Size(281, 69);
            this.BtnContinue.TabIndex = 0;
            this.BtnContinue.Text = "Continue";
            this.BtnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // LabelPause
            // 
            this.LabelPause.AutoSize = true;
            this.LabelPause.BackColor = System.Drawing.Color.Transparent;
            this.LabelPause.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LabelPause.ForeColor = System.Drawing.Color.White;
            this.LabelPause.Location = new System.Drawing.Point(103, 9);
            this.LabelPause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPause.Name = "LabelPause";
            this.LabelPause.Size = new System.Drawing.Size(98, 41);
            this.LabelPause.TabIndex = 1;
            this.LabelPause.Text = "Pause";
            this.LabelPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnRestart
            // 
            this.BtnRestart.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRestart.FlatAppearance.BorderSize = 0;
            this.BtnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(124)))), ((int)(((byte)(235)))));
            this.BtnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.BtnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestart.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnRestart.ForeColor = System.Drawing.Color.White;
            this.BtnRestart.Image = global::Snake.Properties.Resources.Retry;
            this.BtnRestart.Location = new System.Drawing.Point(11, 163);
            this.BtnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnRestart.Size = new System.Drawing.Size(281, 69);
            this.BtnRestart.TabIndex = 2;
            this.BtnRestart.Text = "Restart";
            this.BtnRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRestart.UseVisualStyleBackColor = false;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(124)))), ((int)(((byte)(235)))));
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Image = global::Snake.Properties.Resources.Close;
            this.BtnExit.Location = new System.Drawing.Point(11, 246);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.BtnExit.Size = new System.Drawing.Size(281, 69);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.LabelPause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 62);
            this.panel1.TabIndex = 5;
            // 
            // PauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 322);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.BtnContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PauseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Label LabelPause;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel1;
    }
}