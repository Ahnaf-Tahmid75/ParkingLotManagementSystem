using System;
using System.Windows.Forms;

namespace ParkingLotManagementSystem
{
    public partial class updateform : Form
    {
        public updateform()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update successful!");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
