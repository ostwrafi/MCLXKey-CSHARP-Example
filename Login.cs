using MCLXKey;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KeyAuth
{
    public partial class Login : Form
    {
     
        

        public Login()
        {
            InitializeComponent();
           
        }

    

        private async void Login_Load(object sender, EventArgs e)
        {
          
        }
        
        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private async void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }


        private async void loginBtn_Click_1(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string password = passwordField.Text;
            string hwid = GetHWID(); // optional or static like "HWID123"
            // Call the function
            var result = await MCLXKeyAuth.AuthenticateAsync(username, password, hwid);
            // Check the result
            if (result.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Login failed: " + result.error);
            }
        }

        public static string GetHWID()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
        }


        private async void registerBtn_Click(object sender, EventArgs e)
        {
          
        }

        private async void licenseBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
