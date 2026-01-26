using System;
using System.Windows.Forms;

namespace ParkingLotManagementSystem
{
    public partial class Record_Form : Form
    {
        public Record_Form()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
