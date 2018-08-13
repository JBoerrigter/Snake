namespace Snake
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CurrentGame = new Snake.UiElements.Game();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnRestartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPause = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentGame
            // 
            this.CurrentGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentGame.BackColor = System.Drawing.Color.White;
            this.CurrentGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentGame.Location = new System.Drawing.Point(261, 102);
            this.CurrentGame.Name = "CurrentGame";
            this.CurrentGame.Size = new System.Drawing.Size(599, 447);
            this.CurrentGame.TabIndex = 3;
            this.CurrentGame.Over += new System.EventHandler(this.CurrentGame_Over);
            this.CurrentGame.Paused += new System.EventHandler(this.CurrentGame_Paused);
            this.CurrentGame.Started += new System.EventHandler(this.CurrentGame_Started);
            this.CurrentGame.Continued += new System.EventHandler(this.CurrentGame_Continued);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnNewGame.FlatAppearance.BorderSize = 0;
            this.BtnNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(225)))));
            this.BtnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(134)))), ((int)(((byte)(245)))));
            this.BtnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewGame.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewGame.ForeColor = System.Drawing.Color.White;
            this.BtnNewGame.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewGame.Image")));
            this.BtnNewGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewGame.Location = new System.Drawing.Point(12, 110);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnNewGame.Size = new System.Drawing.Size(228, 80);
            this.BtnNewGame.TabIndex = 4;
            this.BtnNewGame.Text = "New Game";
            this.BtnNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNewGame.UseVisualStyleBackColor = false;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(134)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnRestartGame);
            this.panel1.Controls.Add(this.BtnNewGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 556);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(124)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 96);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(12, 457);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(228, 80);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Exit";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnRestartGame
            // 
            this.BtnRestartGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRestartGame.FlatAppearance.BorderSize = 0;
            this.BtnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestartGame.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestartGame.ForeColor = System.Drawing.Color.White;
            this.BtnRestartGame.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestartGame.Image")));
            this.BtnRestartGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRestartGame.Location = new System.Drawing.Point(12, 208);
            this.BtnRestartGame.Name = "BtnRestartGame";
            this.BtnRestartGame.Size = new System.Drawing.Size(228, 80);
            this.BtnRestartGame.TabIndex = 4;
            this.BtnRestartGame.Text = "Restart";
            this.BtnRestartGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRestartGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRestartGame.UseVisualStyleBackColor = false;
            this.BtnRestartGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Snake";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.BtnPause);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(255, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 96);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "powered by JB";
            // 
            // BtnPause
            // 
            this.BtnPause.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnPause.FlatAppearance.BorderSize = 0;
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPause.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPause.ForeColor = System.Drawing.Color.White;
            this.BtnPause.Image = ((System.Drawing.Image)(resources.GetObject("BtnPause.Image")));
            this.BtnPause.Location = new System.Drawing.Point(513, 10);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(80, 80);
            this.BtnPause.TabIndex = 8;
            this.BtnPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPause.UseVisualStyleBackColor = false;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(868, 556);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CurrentGame);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private UiElements.Game CurrentGame;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnRestartGame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPause;
    }
}

