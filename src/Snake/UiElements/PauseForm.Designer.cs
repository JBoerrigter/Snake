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
            this.SuspendLayout();
            // 
            // BtnContinue
            // 
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnContinue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinue.Location = new System.Drawing.Point(12, 118);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(422, 106);
            this.BtnContinue.TabIndex = 0;
            this.BtnContinue.Text = "Continue";
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // LabelPause
            // 
            this.LabelPause.BackColor = System.Drawing.Color.DodgerBlue;
            this.LabelPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPause.Font = new System.Drawing.Font("Arial", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LabelPause.ForeColor = System.Drawing.Color.White;
            this.LabelPause.Location = new System.Drawing.Point(0, 0);
            this.LabelPause.Name = "LabelPause";
            this.LabelPause.Size = new System.Drawing.Size(442, 107);
            this.LabelPause.TabIndex = 1;
            this.LabelPause.Text = "Pause";
            this.LabelPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnRestart
            // 
            this.BtnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRestart.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestart.Location = new System.Drawing.Point(12, 230);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(422, 106);
            this.BtnRestart.TabIndex = 2;
            this.BtnRestart.Text = "Restart";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(12, 342);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(422, 106);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 460);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.LabelPause);
            this.Controls.Add(this.BtnContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PauseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Label LabelPause;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Button BtnExit;
    }
}