using System;
using System.Windows.Forms;

namespace ParkingLotManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            log_in firstLogin = new log_in();
            firstLogin.Show();
            this.Close();
        }
    }
}
