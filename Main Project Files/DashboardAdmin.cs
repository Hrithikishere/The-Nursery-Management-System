using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Nursery_Management_System
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            new Plant().Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            new Employee().Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            new Stats().Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void btnAboutOxygen_Click(object sender, EventArgs e)
        {
            About_Oxygen about_Oxygen = new About_Oxygen();
            about_Oxygen.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Log_in().Show();
            this.Hide();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            //MessageForLogout.Text = "Logout";
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            //MessageForLogout.Text = "";
        }
    }
}
