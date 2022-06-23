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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OTesting oTesting = new OTesting();
            DataTable dataTable = new DataTable();
            EAdmin eAdmin = new EAdmin();
            OAboutMe oAboutMe = new OAboutMe();
            bool flag;


            if (txtID.Text == eAdmin.Id && txtPassword.Text == eAdmin.Password)
            {
                new DashboardAdmin().Show();
                this.Hide();
            }
            else
            {
                if (oTesting.AvailablityIDPassword(txtID.Text, txtPassword.Text))  //  Login as a Employee
                {
                    dataTable = oTesting.ReturnIDPassword(txtID.Text, txtPassword.Text);
                    string id = dataTable.Rows[0][1].ToString();
                    string password = dataTable.Rows[0][8].ToString();


                    if (id == txtID.Text && password == txtPassword.Text)
                    {
                        DateTime dateTime = new DateTime();
                        dateTime = DateTime.Now;

                        int a;
                        a = oAboutMe.Store( id, dateTime);


                        new DashboardEmployee().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Check your ID or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Check your ID or Password");
                }
            }

           

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkFotgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Forgot_Password().Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
