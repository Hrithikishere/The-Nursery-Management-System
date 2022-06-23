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
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
        }

        private void AboutMe_Load(object sender, EventArgs e)
        {
            bool flag;
            OAboutMe oAboutMe = new OAboutMe();
            DataTable dataTable = new DataTable();
            dataTable = oAboutMe.AboutMe();


            lblName.Text = dataTable.Rows[0][0].ToString();
            lblName.Visible = true;

            lblID.Text = dataTable.Rows[0][1].ToString();
            lblID.Visible = true;

            lblGender.Text = dataTable.Rows[0][2].ToString();
            lblGender.Visible = true;

            lblDateOfBirth.Text = dataTable.Rows[0][3].ToString();
            lblDateOfBirth.Visible = true;

            lblPhone.Text = dataTable.Rows[0][4].ToString();
            lblPhone.Visible = true;

            lblAddress.Text = dataTable.Rows[0][5].ToString();
            lblAddress.Visible = true;

            lblRole.Text = dataTable.Rows[0][6].ToString();
            lblRole.Visible = true;

            lblSalary.Text = dataTable.Rows[0][7].ToString();
            lblSalary.Visible = true;
        }

        private void lblSalary_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            new PlantEmployee().Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new CustomerEmployee().Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new OrderEmployee().Show();
            this.Hide();
        }

        private void btnAboutOxygen_Click(object sender, EventArgs e)
        {
            About_Oxygen about_Oxygen = new About_Oxygen();
            about_Oxygen.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new DashboardEmployee().Show();
            this.Hide();
        }

        private void btnAboutme_Click(object sender, EventArgs e)
        {
            new AboutMe().Show();
            this.Hide();
        }
    }
}
