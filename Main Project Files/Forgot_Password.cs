using NurseryDataAccessLayer.Entities;
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
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void Forgot_Password_Load(object sender, EventArgs e)
        {

        }

        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Log_in().Show();
            this.Hide();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            bool flag;
            string id;
            string phone;
            string password;
            OTesting oTesting = new OTesting();
            DataTable dataTable = new DataTable();
            EAdmin eAdmin = new EAdmin();


            if (txtID.Text == eAdmin.Id && txtPhone.Text == eAdmin.Phone)
            {
                id = eAdmin.Id;
                password = eAdmin.Password;
                MessageBox.Show("ID : " + id + " and Password: " + password);
            }
            else
            {
                if (oTesting.AvailablityIDPhone(txtID.Text, txtPhone.Text))  // ------------------------------ Login as a Employee
                {
                    dataTable = oTesting.ReturnIDPhone(txtID.Text, txtPhone.Text);
                    id = dataTable.Rows[0][1].ToString();
                    phone = dataTable.Rows[0][4].ToString();
                    password = dataTable.Rows[0][8].ToString();

                    if (id == txtID.Text && phone == txtPhone.Text)
                    {
                        MessageBox.Show("ID : " + id + " and Password: " + password);
                    }
                    else
                    {
                        MessageBox.Show("Check your ID or Phone");
                    }
                }
                else
                {
                    MessageBox.Show("Check your ID or Phone");
                }
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
