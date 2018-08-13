using System;
using System.Windows.Forms;

namespace Snake.UiElements
{
    public partial class PauseForm : Form
    {
        IGame currentGame;

        public PauseForm(IGame game)
        {
            InitializeComponent();
            currentGame = game;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            currentGame.Continue();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            currentGame.New();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
