using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string prompt = "鼠标位置(" + e.X.ToString() + "," + e.Y.ToString() + ")";
            this.toolStripStatusLabel1.Text = prompt;
        }

    }
}
