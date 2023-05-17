﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public partial class _3x3 : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int BotWinCount = 0;
        List<Button> buttons;
        public _3x3()
        {
            InitializeComponent();
            RestartGame();
        }
      
        private void BotMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.OrangeRed;
                buttons.RemoveAt(index);
                CheckGame();
                BotTimer.Stop();
            }
        }
        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
               button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
               button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
               button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
               button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
               button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
               button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
               button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                BotTimer.Stop();
                MessageBox.Show("Player WINS");
                playerWinCount++;
                label1.Text = "Player Wins: " + playerWinCount;
                RestartGame();
            }
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
               button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
               button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
               button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
               button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
               button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
               button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
               button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                BotTimer.Stop();
                MessageBox.Show("Bot WINS");
                BotWinCount++;
                label2.Text = "Bot Wins: " + BotWinCount;
                RestartGame();
            }
        }
        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = " ";
                x.BackColor = DefaultBackColor;
            }
        }
        private void PlayerClickButon(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Lavender;
            buttons.Remove(button);
            CheckGame();
            BotTimer.Start();
        }
        private void ExitGame(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
 