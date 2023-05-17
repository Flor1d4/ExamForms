using System;
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
    public partial class _9x9 : Form
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

        public _9x9()
        {
            InitializeComponent();
            RestartGame();
        }


        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void CheckGame()
        {
            if (button1.Text == "X" && button10.Text == "X" && button19.Text == "X" ||
            button2.Text == "X" && button11.Text == "X" && button20.Text == "X" ||
            button3.Text == "X" && button12.Text == "X" && button21.Text == "X" ||
            button4.Text == "X" && button13.Text == "X" && button22.Text == "X" ||
            button5.Text == "X" && button14.Text == "X" && button23.Text == "X" ||
            button6.Text == "X" && button15.Text == "X" && button24.Text == "X" ||
            button7.Text == "X" && button16.Text == "X" && button25.Text == "X" ||
            button8.Text == "X" && button17.Text == "X" && button26.Text == "X" ||
            button9.Text == "X" && button18.Text == "X" && button27.Text == "X" ||
            button1.Text == "X" && button11.Text == "X" && button21.Text == "X" ||
            button2.Text == "X" && button12.Text == "X" && button22.Text == "X" ||
            button3.Text == "X" && button13.Text == "X" && button23.Text == "X" ||
            button4.Text == "X" && button14.Text == "X" && button24.Text == "X" ||
            button5.Text == "X" && button15.Text == "X" && button25.Text == "X" ||
            button6.Text == "X" && button16.Text == "X" && button26.Text == "X" ||
            button7.Text == "X" && button17.Text == "X" && button27.Text == "X" ||
            button8.Text == "X" && button18.Text == "X" && button28.Text == "X" ||
            button10.Text == "X" && button11.Text == "X" && button12.Text == "X" ||
            button13.Text == "X" && button14.Text == "X" && button15.Text == "X" ||
            button16.Text == "X" && button17.Text == "X" && button18.Text == "X" ||
            button19.Text == "X" && button20.Text == "X" && button21.Text == "X" ||
            button22.Text == "X" && button23.Text == "X" && button24.Text == "X" ||
            button25.Text == "X" && button26.Text == "X" && button27.Text == "X" ||
            button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
            button19.Text == "X" && button23.Text == "X" && button27.Text == "X" ||
            button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
            button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
            button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
            button10.Text == "X" && button11.Text == "X" && button12.Text == "X" ||
            button13.Text == "X" && button14.Text == "X" && button15.Text == "X" ||
            button16.Text == "X" && button17.Text == "X" && button18.Text == "X" ||
            button19.Text == "X" && button20.Text == "X" && button21.Text == "X" ||
            button22.Text == "X" && button23.Text == "X" && button24.Text == "X" ||
            button25.Text == "X" && button26.Text == "X" && button27.Text == "X" ||
            button28.Text == "X" && button29.Text == "X" && button30.Text == "X" ||
            button31.Text == "X" && button32.Text == "X" && button33.Text == "X" ||
            button34.Text == "X" && button35.Text == "X" && button36.Text == "X" ||
            button37.Text == "X" && button38.Text == "X" && button39.Text == "X" ||
            button40.Text == "X" && button41.Text == "X" && button42.Text == "X" ||
            button43.Text == "X" && button44.Text == "X" && button45.Text == "X" ||
            button46.Text == "X" && button47.Text == "X" && button48.Text == "X" ||
            button49.Text == "X" && button50.Text == "X" && button51.Text == "X" ||
            button52.Text == "X" && button53.Text == "X" && button54.Text == "X" ||
            button55.Text == "X" && button56.Text == "X" && button57.Text == "X" ||
            button58.Text == "X" && button59.Text == "X" && button60.Text == "X" ||
            button61.Text == "X" && button62.Text == "X" && button63.Text == "X" ||
            button64.Text == "X" && button65.Text == "X" && button66.Text == "X" ||
            button67.Text == "X" && button68.Text == "X" && button69.Text == "X" ||
            button70.Text == "X" && button71.Text == "X" && button72.Text == "X" ||
            button73.Text == "X" && button74.Text == "X" && button75.Text == "X" ||
            button76.Text == "X" && button77.Text == "X" && button78.Text == "X" ||
            button79.Text == "X" && button80.Text == "X" && button81.Text == "X")
            {
                BotTimer.Stop();
                MessageBox.Show("Player WINS");
                playerWinCount++;
                label1.Text = "Player Wins: " + playerWinCount;
                RestartGame();

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
            button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
            button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
            button10.Text == "O" && button11.Text == "O" && button12.Text == "O" ||
            button13.Text == "O" && button14.Text == "O" && button15.Text == "O" ||
            button16.Text == "O" && button17.Text == "O" && button18.Text == "O" ||
            button19.Text == "O" && button20.Text == "O" && button21.Text == "O" ||
            button22.Text == "O" && button23.Text == "O" && button24.Text == "O" ||
            button25.Text == "O" && button26.Text == "O" && button27.Text == "O" ||
            button28.Text == "O" && button29.Text == "O" && button30.Text == "O" ||
            button31.Text == "O" && button32.Text == "O" && button33.Text == "O" ||
            button34.Text == "O" && button35.Text == "O" && button36.Text == "O" ||
            button37.Text == "O" && button38.Text == "O" && button39.Text == "O" ||
            button40.Text == "O" && button41.Text == "O" && button42.Text == "O" ||
            button43.Text == "O" && button44.Text == "O" && button45.Text == "O" ||
            button46.Text == "O" && button47.Text == "O" && button48.Text == "O" ||
            button49.Text == "O" && button50.Text == "O" && button51.Text == "O" ||
            button52.Text == "O" && button53.Text == "O" && button54.Text == "O" ||
            button55.Text == "O" && button56.Text == "O" && button57.Text == "O" ||
            button58.Text == "O" && button59.Text == "O" && button60.Text == "O" ||
            button61.Text == "O" && button62.Text == "O" && button63.Text == "O" ||
            button64.Text == "O" && button65.Text == "O" && button66.Text == "O" ||
            button67.Text == "O" && button68.Text == "O" && button69.Text == "O" ||
            button70.Text == "O" && button71.Text == "O" && button72.Text == "O" ||
            button73.Text == "O" && button74.Text == "O" && button75.Text == "O" ||
            button76.Text == "O" && button77.Text == "O" && button78.Text == "O" ||
            button79.Text == "O" && button80.Text == "O" && button81.Text == "O" |
            button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
            button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
            button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
            button10.Text == "O" && button13.Text == "O" && button16.Text == "O" ||
            button11.Text == "O" && button14.Text == "O" && button17.Text == "O" ||
            button12.Text == "O" && button15.Text == "O" && button18.Text == "O" ||
            button19.Text == "O" && button22.Text == "O" && button25.Text == "O" ||
            button20.Text == "O" && button23.Text == "O" && button26.Text == "O" ||
            button21.Text == "O" && button24.Text == "O" && button27.Text == "O" ||
            button28.Text == "O" && button31.Text == "O" && button34.Text == "O" ||
            button29.Text == "O" && button32.Text == "O" && button35.Text == "O" ||
            button30.Text == "O" && button33.Text == "O" && button36.Text == "O" ||
            button37.Text == "O" && button40.Text == "O" && button43.Text == "O" ||
            button38.Text == "O" && button41.Text == "O" && button44.Text == "O" ||
            button39.Text == "O" && button42.Text == "O" && button45.Text == "O" ||
            button46.Text == "O" && button49.Text == "O" && button52.Text == "O" ||
            button47.Text == "O" && button50.Text == "O" && button53.Text == "O" ||
            button48.Text == "O" && button51.Text == "O" && button54.Text == "O" ||
            button55.Text == "O" && button58.Text == "O" && button61.Text == "O" ||
            button56.Text == "O" && button59.Text == "O" && button62.Text == "O" ||
            button57.Text == "O" && button60.Text == "O" && button63.Text == "O" ||
            button64.Text == "O" && button67.Text == "O" && button70.Text == "O" ||
            button65.Text == "O" && button68.Text == "O" && button71.Text == "O" ||
            button66.Text == "O" && button69.Text == "O" && button72.Text == "O" ||
            button73.Text == "O" && button76.Text == "O" && button79.Text == "O" ||
            button74.Text == "O" && button77.Text == "O" && button80.Text == "O" ||
            button75.Text == "O" && button78.Text == "O" && button81.Text == "O" ||
            button1.Text == "O" && button10.Text == "O" && button19.Text == "O")
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
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, 
                button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, 
                button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, 
                button31, button32, button33, button34, button35, button36, button37, button38, button39, button40, 
                button41, button42, button43, button44, button45, button46, button47, button48, button49, button50,
                button51, button52, button53, button54, button55, button56, button57, button58, button59, button60, 
                button61, button62, button63, button64, button65, button66, button67, button68, button69, button70, 
                button71, button72, button73, button74, button75, button76, button77, button78, button79, button80, button81 };
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = " ";
                x.BackColor = DefaultBackColor;

            }
        }
      

        private void PlayerClickButton(object sender, EventArgs e)
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

        private void ExitGame(object sender, EventArgs e)
        {
              Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
