using System;
using System.Windows.Forms;

namespace Snake.UiElements
{
    public partial class PauseForm : Form
    {
        readonly IGame _currentGame;

        public PauseForm(IGame game)
        {
            InitializeComponent();
            _currentGame = game;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            _currentGame.Continue();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            _currentGame.New();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
