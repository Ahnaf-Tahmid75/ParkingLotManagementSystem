using System;
using System.Windows.Forms;
using ParkingLotManagementSystem.Services;
using ParkingLotManagementSystem.Models;

namespace ParkingLotManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            AuthService authService = new AuthService();
            User user = authService.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password", "Login Failed");
                return;
            }

            MessageBox.Show($"Welcome {user.Username} ({user.Role})", "Login Success");
        }
    }
}


