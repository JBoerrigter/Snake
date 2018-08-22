using Snake.Properties;
using Snake.UiElements;
using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class MainForm : Form
    {
        OverForm over;
        PauseForm pause;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            CurrentGame.New();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CurrentGame_Started(object sender, EventArgs e)
        {
            CloseUiForms();

            // Show / Hide Buttons
            BtnNewGame.Visible = false;
            BtnRestartGame.Visible = true;

            // Otherwise KeyDown (MainForm) wont trigger
            CurrentGame.Focus();
        }

        private void CurrentGame_Continued(object sender, EventArgs e)
        {
            CloseUiForms();
        }

        private void CurrentGame_Paused(object sender, EventArgs e)
        {
            if (pause == null)
                pause = new PauseForm(CurrentGame);
            pause.ShowDialog(this);

            // Otherwise KeyDown (MainForm) wont trigger
            CurrentGame.Focus();
        }

        private void CurrentGame_Over(object sender, EventArgs e)
        {
            if (over == null)
                over = new OverForm(CurrentGame);
            over.ShowDialog(this);

            // Otherwise KeyDown (MainForm) wont trigger
            CurrentGame.Focus();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            CurrentGame.Update(e);
        }

        private void CloseUiForms()
        {
            if (pause != null && pause.Visible)
                pause.Close();

            if (over != null && over.Visible)
                over.Close();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            CurrentGame.Pause();
        }

        private void CurrentGame_PointsChanged(object sender, EventArgs e)
        {
            pointsValue.Text = CurrentGame.Points.ToString();
        }
    }
}
