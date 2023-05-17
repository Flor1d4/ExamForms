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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ReturnToStart(object sender, EventArgs e)
        {
            Start start = new Start();            
            this.Hide();         
            start.ShowDialog();
            
        }

        private void Start3x3(object sender, EventArgs e)
        {
            _3x3 _3x3= new _3x3();
            this.Hide();
            _3x3.ShowDialog();
        }

        private void Start9x9(object sender, EventArgs e)
        {
            _9x9 _9x9 = new _9x9();
            this.Hide();
            _9x9.ShowDialog();
        }
    }
}
