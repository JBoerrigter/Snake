﻿using System;
using System.Windows.Forms;

namespace Snake.UiElements
{
    public partial class OverForm : Form
    {
        IGame currentGame;

        public OverForm(IGame game)
        {
            InitializeComponent();
            currentGame = game;
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
