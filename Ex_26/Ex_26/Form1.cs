using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ViewRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void ViewYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void ViewBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Equals(toolBarViewRed))
            {
                this.ViewRed_Click(sender, e);
            }
            else if(e.ClickedItem.Equals(toolbarViewBlue))
            {
                this.ViewBlue_Click(sender, e);
            }
            else if(e.ClickedItem.Equals(toolBarViewYellow))
            {
                this.ViewYellow_Click(sender, e);
            }
            else if(e.ClickedItem.Equals(toolBarFileExit))
            {
                this.FileExit_Click(sender, e);
            }
            else if(e.ClickedItem.Equals(toolBarHelpAbout))
            {
                this.HelpAbout_Click(sender, e);
            }

        }

        private void HelpAbout_Click(object sender, EventArgs e)
        {

        }




    }
}
