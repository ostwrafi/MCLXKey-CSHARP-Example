
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
           
        }

        private async void Main_Load(object sender, EventArgs e)
        {
           
        }



    
        private async void sendMsgBtn_Click_1(object sender, EventArgs e)
        {
           
        }

        private async void closeBtn_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}