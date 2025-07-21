using MCLXKey;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KeyAuth
{
    public partial class Main : Form
    {
        private MCLXKeyAuth.User user;

        public Main(MCLXKeyAuth.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                xd.Text = $"ID: {user.id}";
                label3.Text = $"Name: {user.name}\nUsername: {user.username}\nExpires: {user.expireDate}";
            }
        }

        private async void sendMsgBtn_Click_1(object sender, EventArgs e)
        {
           
        }
      // application close and minimize buttons
        // This method is called when the close button is clicked
        private async void closeBtn_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}