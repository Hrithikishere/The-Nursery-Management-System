using NurseryDataAccessLayer.Entities;
using NurseryDataAccessLayer.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Nursery_Management_System
{
    public partial class CustomerEmployee : Form
    {
        public CustomerEmployee()
        {
            InitializeComponent();
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

        private void btnAboutme_Click(object sender, EventArgs e)
        {
            new AboutMe().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ECustomer eCustomer = new ECustomer();
            OCustomer oCustomer = new OCustomer();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck all sections!";
            double testDouble;
            int testInt;

            string test = txtName.Text;            // ----------------------------------------------------------------------Insert _ Name 
            bool flag = false;
            flag = test.All(c => Char.IsLetter(c) || c == ' ');
            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any number or symbols.";
            }
            else
            {
                eCustomer.Name = txtName.Text;

                count++;  //count = 1
            } // end



            flag = false;
            test = txtID.Text;                    // ------------------------------------------------------------------------Insert _ ID 
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "C") && flag && (!oTesting.AvailablityCustomerID(test)))  //IsNotNull? and 'C' in first
            {
                eCustomer.Id = txtID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nEnter a unique and valid ID in Number, starts with C.";
            }//end



            if (rbtnMale.Checked)          //-----------------------------------------------------------------------------Insert _ Gender
            {
                eCustomer.Gender = rbtnMale.Text;
                rbtnFemale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if (rbtnFemale.Checked)
            {
                eCustomer.Gender = rbtnFemale.Text;
                rbtnMale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if(rbtnOther.Checked)
            {
                eCustomer.Gender = rbtnOther.Text;
                rbtnFemale.Checked = false;
                rbtnMale.Checked = false;
                count++;  // count = 3
            }
            else
            {
                output = output + "\nSelect Gender.";

            }//end


            test = txtAddress.Text;   //----------------------------------------------------------------------------------Insert _Address
            if (string.IsNullOrEmpty(test))  // is it null?
            {
                output = output + "\nEnter Address.";
            }
            else
            {
                eCustomer.Address = txtAddress.Text;

                count++;  // Count = 6
            }//end



            test = txtPhone.Text;               // -----------------------------------------------------------------Insert _ Phone Number
            if ((test.All(Char.IsDigit)) && !string.IsNullOrEmpty(test))  // all are numbers and not null 
            {
                eCustomer.Phone = txtPhone.Text;

                count++; //count = 5
            }
            else
            {
                output = output + "\nEnter Valid Phone Number.";
            }//end



            if (count == 5) // ---------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oCustomer.Insert(eCustomer);

                if (check > 0)
                {
                    MessageBox.Show("Inserted!");
                    count = 0;
                    output = "Please fill up or recheck all sections!";
                }
                else
                {
                    MessageBox.Show("Insertion Failed!");
                    count = 0;
                    output = "Please fill up or recheck all sections!";
                }
            }
            else
            {
                MessageBox.Show(output);
                count = 0;//--------------------------------------------------count must be zero to reset
                output = "Please fill up or recheck all sections!"; //------------------- reset to default
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ECustomer eCustomer = new ECustomer();
            OCustomer oCustomer = new OCustomer();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck all sections!";
            double testDouble;
            int testInt;

            string test = txtName.Text;            // ---------------------------------------------------------------------Update_ Name 
            bool flag = false;
            flag = test.All(c => Char.IsLetter(c) || c == ' ');
            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any number or symbols.";
            }
            else
            {
                eCustomer.Name = txtName.Text;

                count++;  //count = 1
            } // end



            flag = false;
            test = txtID.Text;                    // ------------------------------------------------------------------------Update _ ID 
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "C") && flag && (oTesting.AvailablityCustomerID(test)))  //IsNotNull? and 'C' in first
            {
                eCustomer.Id = txtID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nEnter valid ID in Number, starts with C.";
            }//end



            if (rbtnMale.Checked)          //----------------------------------------------------------------------------Update _ Gender
            {
                eCustomer.Gender = rbtnMale.Text;
                rbtnFemale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if (rbtnFemale.Checked)
            {
                eCustomer.Gender = rbtnFemale.Text;
                rbtnMale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if(rbtnOther.Checked)
            {
                eCustomer.Gender = rbtnOther.Text;
                rbtnFemale.Checked = false;
                rbtnMale.Checked = false;
                count++;  // count = 3
            }
            else
            {
                output = output + "\nSelect Gender.";
            }



            test = txtAddress.Text;   //----------------------------------------------------------------------------------Update _Address
            if (string.IsNullOrEmpty(test))  // is it null?
            {
                output = output + "\nEnter Address.";
            }
            else
            {
                eCustomer.Address = txtAddress.Text;

                count++;  // Count = 6
            }//end



            test = txtPhone.Text;               // ----------------------------------------------------------------Update_Phone Number
            if ((test.All(Char.IsDigit)) && !string.IsNullOrEmpty(test))  // all are numbers and not null 
            {
                eCustomer.Phone = txtPhone.Text;

                count++; //count = 5
            }
            else
            {
                output = output + "\nEnter Valid Phone Number.";
            }//end



            if (count == 5) // ---------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oCustomer.Update(eCustomer);

                if (check > 0)
                {
                    MessageBox.Show("Updated!");
                    count = 0;
                    output = "Please fill up or recheck all sections!";
                }
                else
                {
                    MessageBox.Show("Update Failed!");
                    count = 0;
                    output = "Please fill up or recheck all sections!";
                }
            }
            else
            {
                MessageBox.Show(output);
                count = 0;//--------------------------------------------------count must be zero to reset
                output = "Please fill up or recheck all sections!"; //------------------- reset to default
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ECustomer eCustomer = new ECustomer();
            OCustomer oCustomer = new OCustomer();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck entered ID!";
            double testDouble;
            int testInt;               
            bool flag = false;
           


            flag = false;
            string test = txtID.Text;                    // ------------------------------------------------------------------------Delete _ ID 
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "C") && flag && (oTesting.AvailablityCustomerID(test)))  //IsNotNull? and 'C' in first
            {
                eCustomer.Id = txtID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nEnter valid ID in Number, starts with C.";
            }//end



            if (count == 1) // ---------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oCustomer.Delete(eCustomer);

                if (check > 0)
                {
                    MessageBox.Show("Deleted!");
                    count = 0;
                    output = "Please fill up or recheck entered ID!";
                }
                else
                {
                    MessageBox.Show("Deletion Failed!");
                    count = 0;
                    output = "Please fill up or recheck entered ID!";
                }
            }
            else
            {
                MessageBox.Show(output);
                count = 0;//--------------------------------------------------count must be zero to reset
                output = "Please fill up or recheck entered ID!"; //------------------- reset to default
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OCustomer oCustomer = new OCustomer();
            SqlDataAdapter sqlDataAdapter = oCustomer.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataViewCustomer.DataSource = dataTable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OCustomer oCustomer = new OCustomer();

            if (oCustomer.AvailablitiyCustomerID(txtSearch.Text))
            {
                SqlDataAdapter sqlDataAdapter = oCustomer.ReturnCustomerIDInfo(txtSearch.Text);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataViewCustomer.DataSource = dataTable;
            }
            else if (oCustomer.AvailablitiyCustomerName(txtSearch.Text))
            {
                SqlDataAdapter sqlDataAdapter = oCustomer.ReturnCustomerNameInfo(txtSearch.Text);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataViewCustomer.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No Customer Found!");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new DashboardEmployee().Show();
            this.Hide();
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
           // MessageForDelete.Text = "Enter Name and ID to delete";
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
          //  MessageForDelete.Text = "";
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
           // MessageForSearch.Text = "Search Customer by Name or ID";
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
         //   MessageForSearch.Text = "";
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            //MessageForHome.Text = "Dashboard / Admin";
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
          //  MessageForHome.Text = "";
        }
    }
}
