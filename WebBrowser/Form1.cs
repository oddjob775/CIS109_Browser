using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(cmboLocation.Text);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void FwdBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmboLocation.Text);
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
    }
}
