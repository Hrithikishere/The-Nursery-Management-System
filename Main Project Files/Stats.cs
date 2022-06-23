using NurseryDataAccessLayer.Operations;
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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            OStats oStats = new OStats();

            double output;

            output = oStats.TotalSale();
            lblSaleAmount.Text = output.ToString();
            lblSaleAmount.Visible = true;

            output = oStats.TotalCustomer();
            lblCustomerAmount.Text = output.ToString();
            lblCustomerAmount.Visible = true;

            output = oStats.TotalEmployee();
            lblEmployeeAmount.Text = output.ToString();
            lblEmployeeAmount.Visible = true;

            output = oStats.TotalOrder();
            lblOrderAmount.Text = output.ToString();
            lblOrderAmount.Visible = true;

            output = oStats.TotalDeliveredOrder();
            lblDeliveredOrderAmount.Text = output.ToString();
            lblDeliveredOrderAmount.Visible = true;

            output = oStats.TotalPlant();
            lblPlantAmount.Text = output.ToString();
            lblPlantAmount.Visible = true;
        }

        private void lblDeliveredOrderAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblPlantAmount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            new Plant().Show();
            this.Hide();
        }

        private void btnAboutOxygen_Click(object sender, EventArgs e)
        {
            About_Oxygen about_Oxygen = new About_Oxygen();
            about_Oxygen.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            new Stats().Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            new Employee().Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new DashboardAdmin().Show();
            this.Hide();
        }
    }
    
}
