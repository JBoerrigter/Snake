using System;
using System.Windows.Forms;

namespace Snake.UiElements
{
    public partial class GameOverForm : Form
    {
        readonly IGame _currentGame;

        public GameOverForm(IGame game)
        {
            InitializeComponent();
            _currentGame = game;
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
