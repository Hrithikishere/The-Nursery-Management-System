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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EEmployee eEmployee = new EEmployee();
            OEmployee oEmployee = new OEmployee();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck all sections!";
            double testDouble;
            int testInt;



            string test = txtName.Text;            // -----------------------------------------------------------Insert _ Name 
            bool flag = false;
            flag = test.All(c => Char.IsLetter(c) || c == ' ');
            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any number or symbols.";
            }
            else
            {
                eEmployee.Name = txtName.Text;
                count++;  //count = 1
            } // end



            flag = false;
            test = txtID.Text;                    // -----------------------------------------------------------Insert _ ID 
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "E") && flag && (!oTesting.AvailablityEmployeeID(test)))  //IsNotNull? and 'E' in first
            {
                eEmployee.Id = txtID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nEnter a unique and valid ID in Number, starts with E.";
            }//end



            if (rbtnMale.Checked)          //----------------------------------------------------------------------------Insert _ Gender
            {
                eEmployee.Gender = rbtnMale.Text;
                rbtnFemale.Checked = false;
                rbtnOther.Checked = false;
                count++;
                
            }
            else if (rbtnFemale.Checked)
            {
                eEmployee.Gender = rbtnFemale.Text;
                rbtnMale.Checked = false;
                rbtnOther.Checked = false;
                count++;
               
            }
            else if(rbtnOther.Checked)
            {
                eEmployee.Gender = rbtnOther.Text;
                rbtnFemale.Checked = false;
                rbtnMale.Checked = false;
                count++;  // count = 3
            }
            else
            {
                output = output + "\nSelect Gender.";
            }



            DateTime testDate = dateOfBirth.Value;   //----------------------------------------------------------------Insert Date Time
            DateTime adult = new DateTime(2003, 07, 17);
            if (testDate < adult)
            {
                eEmployee.Dob = dateOfBirth.Value;
                count++; //count = 4
            }
            else
            {
                output = output + "\nSelect Date of Birth correctly.\n'Must be adult or 18 years old to be an employee'";
            }//end

            

            test = txtPhone.Text;               // -----------------------------------------------------------------Insert _ Phone Number
            if ((test.All(Char.IsDigit)) && !string.IsNullOrEmpty(test))  // all are numbers and not null 
            {
                eEmployee.Phone = txtPhone.Text;
                count++; //count = 5
            }
            else
            {
                output = output + "\nEnter Valid Phone Number.";
            }//end



            test = txtAddress.Text;   //----------------------------------------------------------------------------------Insert _Address
            if (string.IsNullOrEmpty(test))  // is it null?
            {
                output = output + "\nEnter Address.";
            }
            else
            {
                eEmployee.Address = txtAddress.Text;
                count++;  // Count = 6
            }//end



            test = cmbRole.Text;   //-----------------------------------------------------------------------------------------Insert Role
            if (string.IsNullOrEmpty(test))   //is it null?
            {
                output = output + "\nSelect Role.";
            }
            else
            {
                eEmployee.Role = cmbRole.Text;
                count++;  //Count = 7
            }//end



            flag = false;
            bool flag2 = true;
            test = txtSalary.Text;               // ----------------------------------------------------------------------Insert _ Salary 
            int dot = 0;
            for (int i = 0; i < test.Length; i++)  // this for loop is checking amount of '.'
            {
                if (Char.IsPunctuation(test[i]))
                {
                    dot++;
                }
                if (dot > 1)
                {
                    flag2 = false;
                }
            }
            flag = test.All(c => Char.IsDigit(c) || c == '.');    //this is checking is it only digit and '.'
            if (flag && !string.IsNullOrEmpty(test) && flag2 )  // all are integers and not null = 0
            {
                testDouble = Convert.ToDouble(txtSalary.Text);   //Convert into double to check = 0 
                if (testDouble > 0)
                {
                    eEmployee.Salary = Convert.ToDouble(txtSalary.Text);
                    count++;  //count = 8 
                }
                else
                {
                    output = output + "\nEnter Valid Salary.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Salary.";
            }//end



            test = txtPassword.Text;   //---------------------------------------------------------------------------------Insert Password
            int length = test.Length;
            if (string.IsNullOrEmpty(test))  //is it null?
            {
                output = output + "\nEnter Password.";
            }
            else
            {
                if (length > 5)
                {
                    eEmployee.Password = txtPassword.Text;
                    count++;  //count = 9
                }
                else
                {
                    output = output + "\nEnter Password at least 6 letters.";
                }
            }

            

            if (count == 9) // ----------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oEmployee.Insert(eEmployee);

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

        private void btnShow_Click(object sender, EventArgs e)
        {
            OEmployee oEmployee = new OEmployee();
            SqlDataAdapter sqlDataAdapter = oEmployee.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataViewEmployee.DataSource = dataTable;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OEmployee oprEmployee = new OEmployee();

            if (oprEmployee.AvailablitiyEmployeeID(txtSearch.Text))
            {
                SqlDataAdapter sqlDataAdapter = oprEmployee.ReturnEmployeeIDInfo(txtSearch.Text);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataViewEmployee.DataSource = dataTable;
            }
            else if (oprEmployee.AvailablitiyEmployeeName(txtSearch.Text))
            {
                SqlDataAdapter sqlDataAdapter = oprEmployee.ReturnEmployeeNameInfo(txtSearch.Text);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataViewEmployee.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No Employee Found!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            EEmployee eEmployee = new EEmployee();
            OEmployee oEmployee = new OEmployee();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck all sections!";
            double testDouble;
            int testInt;



            string test = txtName.Text;            // ---------------------------------------------------------------------Update _ Name 
            bool flag = false;
            flag = test.All(c => Char.IsLetter(c) || c == ' ');
            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any number or symbols.";
            }
            else
            {
                eEmployee.Name = txtName.Text;
                count++;  //count = 1
            } // end



            flag = false;
            test = txtID.Text;                    // -----------------------------------------------------------------------Update _ ID 
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "E") && flag && (oTesting.AvailablityEmployeeID(test)))  //IsNotNull? and 'E' in first
            {
                eEmployee.Id = txtID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nEnter a valid ID in Number, starts with E.";
            }//end



            if (rbtnMale.Checked)          //----------------------------------------------------------------------------Update _ Gender
            {
                eEmployee.Gender = rbtnMale.Text;
                rbtnFemale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if (rbtnFemale.Checked)
            {
                eEmployee.Gender = rbtnFemale.Text;
                rbtnMale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if(rbtnOther.Checked)
            {
                eEmployee.Gender = rbtnOther.Text;
                rbtnFemale.Checked = false;
                rbtnMale.Checked = false;
                count++;  // count = 3
            }
            else
            {
                output = output + "\nSelect Gender.";

            }///end



            DateTime testDate = dateOfBirth.Value;   //----------------------------------------------------------------Update Date Time
            DateTime adult = new DateTime(2003, 07, 17);
            if (testDate < adult)
            {
                eEmployee.Dob = dateOfBirth.Value;
                count++; //count = 4
            }
            else
            {
                output = output + "\nSelect Date of Birth correctly.\n'Must be adult or 18 years old to be an employee'";
            }//end



            test = txtPhone.Text;               // -----------------------------------------------------------------Update _ Phone Number
            if ((test.All(Char.IsDigit)) && !string.IsNullOrEmpty(test))  // all are numbers and not null 
            {
                eEmployee.Phone = txtPhone.Text;
                count++; //count = 5
            }
            else
            {
                output = output + "\nEnter Valid Phone Number.";
            }//end



            test = txtAddress.Text;   //----------------------------------------------------------------------------------Update _Address
            if (string.IsNullOrEmpty(test))  // is it null?
            {
                output = output + "\nEnter Address.";
            }
            else
            {
                eEmployee.Address = txtAddress.Text;
                count++;  // Count = 6
            }//end



            test = cmbRole.Text;   //-----------------------------------------------------------------------------------------Update Role
            if (string.IsNullOrEmpty(test))   //is it null?
            {
                output = output + "\nSelect Role.";
            }
            else
            {
                eEmployee.Role = cmbRole.Text;
                count++;  //Count = 7
            }//end



            flag = false;
            bool flag2 = true;
            test = txtSalary.Text;               // ----------------------------------------------------------------------Update _ Salary 
            int dot = 0;
            for (int i = 0; i < test.Length; i++)  // this for loop is checking amount of '.'
            {
                if (Char.IsPunctuation(test[i]))
                {
                    dot++;
                }
                if (dot > 1)
                {
                    flag2 = false;
                }
            }
            flag = test.All(c => Char.IsDigit(c) || c == '.');    //this is checking is it only digit and '.'
            if (flag && !string.IsNullOrEmpty(test) && flag2)  // all are integers and not null = 0
            {
                testDouble = Convert.ToDouble(txtSalary.Text);   //Convert into double to check = 0 
                if (testDouble > 0)
                {
                    eEmployee.Salary = Convert.ToDouble(txtSalary.Text);
                    count++;  //count = 8 
                }
                else
                {
                    output = output + "\nEnter Valid Salary.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Salary.";
            }//end



            test = txtPassword.Text;   //---------------------------------------------------------------------------------Update Password
            int length = test.Length;
            if (string.IsNullOrEmpty(test))  //is it null?
            {
                output = output + "\nEnter Password.";
            }
            else
            {
                if (length > 5)
                {
                    eEmployee.Password = txtPassword.Text;
                    count++;  //count = 9
                }
                else
                {
                    output = output + "\nEnter Password at least 6 letters.";
                }
            }



            if (count == 9) // ----------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oEmployee.Update(eEmployee);

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
            EEmployee eEmployee = new EEmployee();
            OEmployee oEmployee = new OEmployee();
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
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "E") && flag && (oTesting.AvailablityEmployeeID(test)))  //IsNotNull? and 'E' in first
            {
                eEmployee.Id = txtID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nEnter valid ID in Number, starts with E.";
            }//end



            if (count == 1) // ---------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oEmployee.Delete(eEmployee);

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
                output = "Please fill up or recheck ID!"; //------------------- reset to default
            }
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            new DashboardAdmin().Show();
            this.Hide();
        }
    }
}
