using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Exam1._3x3;

namespace Exam1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
           Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();

        }

        private void ExitGame(object sender, EventArgs e)
        {
            Start start = new Start();
            MessageBox.Show("Goodbye!");
            this.Close();
        }
    }
}
