using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "选择图片";
            fdlg.InitialDirectory = "c:\\";
            fdlg.Filter = "All files(*.*)|*.*|Image files(*.jpg,*.bmp,*.gif)|*.jpg;*.bmp;*.gif";
            fdlg.FilterIndex = 2;
		
		      if(fdlg.ShowDialog() == DialogResult.OK)
              {
                  pbPicture.Image = Image.FromFile(fdlg.FileName);
			
              }
        }
	
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
