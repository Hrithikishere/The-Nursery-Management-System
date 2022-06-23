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

   
    public partial class Plant : Form
    {
        public Plant()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EPlant ePlant = new EPlant();
            OPlant oplant = new OPlant();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck all sections!";
            double testDouble;
            int testInt;



            string test = txtName.Text;            // ---------------------------------------------------------------------Insert _ Name
            bool flag = false;
            flag = test.All(c => Char.IsLetter(c) || c == ' ');
            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any number or symbols.";
            }
            else
            {
                ePlant.Name = txtName.Text;


                count++;  //count = 1
            } // end



            flag = false;
            test = txtID.Text;                    // -----------------------------------------------------------------------Insert _ ID 
            for (int i = 1; i < test.Length; i++)
            {
                //flag = int.TryParse(txtID.Text, out i);
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "P") && flag && (!oTesting.AvailablityPlantID(test)))  //IsNotNull? and 'P' in first
            {
                ePlant.Id = txtID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nEnter a unique and valid ID in Number, starts with P.";
            }//end



            test = cmbCategory.Text;   //---------------------------------------------------------------------------------Insert Category
            if (string.IsNullOrEmpty(test))   //is it null?
            {
                output = output + "\nSelect Category.";
            }
            else
            {
                ePlant.Category = cmbCategory.Text;
                count++;  //Count = 3
            }//end



            flag = false;
            test = txtAmount.Text;                 // --------------------------------------------------------------------Insert _ Amount
            if ((test.All(Char.IsDigit)) && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testInt = Convert.ToInt32(txtAmount.Text);   //Convert into double to check = 0 

                if (testInt > 0)
                {
                    ePlant.Amount = Convert.ToInt32(txtAmount.Text);
                    count++;  //count = 4
                }
                else
                {
                    output = output + "\nEnter Valid Amount.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Amount.";
            }//end



            flag = false;
            bool flag2 = true;
            test = txtPrice.Text;               // ----------------------------------------------------------------------Insert _ Price 
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
            if (flag && !string.IsNullOrEmpty(test) && flag2)
            {
                testDouble = Convert.ToDouble(txtPrice.Text);
                if (testDouble > 0)
                {
                    ePlant.Price = Convert.ToDouble(txtPrice.Text);
                    count++;
                }
                else
                {
                    output = output + "\nEnter Valid Price.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Price.";
            }//end



            if (count == 5) // --------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oplant.Insert(ePlant);

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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OPlant oPlant = new OPlant();
            SqlDataAdapter sqlDataAdapter = oPlant.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataViewPlant.DataSource = dataTable;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            EPlant ePlant = new EPlant();
            OPlant oplant = new OPlant();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck entered ID!";
            double testDouble;
            int testInt;
            bool flag = false;
           


            flag = false;
            string test = txtID.Text;                    // -----------------------------------------------------------------------Delete _ ID 
            for (int i = 1; i < test.Length; i++)
            {
                //flag = int.TryParse(txtID.Text, out i);
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "P") && flag && (oTesting.AvailablityPlantID(test)))  //IsNotNull? and 'P' in first
            {
                ePlant.Id = txtID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nEnter a valid ID in Number, starts with P.";
            }//end



            if (count == 1) // --------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oplant.Delete(ePlant);

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


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            EPlant ePlant = new EPlant();
            OPlant oplant = new OPlant();
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
                ePlant.Name = txtName.Text;


                count++;  //count = 1
            } // end



            flag = false;
            test = txtID.Text;                    // -----------------------------------------------------------------------Update _ ID 
            for (int i = 1; i < test.Length; i++)
            {
                //flag = int.TryParse(txtID.Text, out i);
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "P") && flag && (oTesting.AvailablityPlantID(test)))  //IsNotNull? and 'P' in first
            {
                ePlant.Id = txtID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nEnter a valid ID in Number, starts with P.";
            }//end



            test = cmbCategory.Text;   //-------------------------------------------------------------------------------Update Category
            if (string.IsNullOrEmpty(test))   //is it null?
            {
                output = output + "\nSelect Category.";
            }
            else
            {
                ePlant.Category = cmbCategory.Text;
                count++;  //Count = 3
            }//end



            flag = false;
            test = txtAmount.Text;                 // -----------------------------------------------------------------Update _ Amount
            if ((test.All(Char.IsDigit)) && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testInt = Convert.ToInt32(txtAmount.Text);   //Convert into double to check = 0 

                if (testInt > 0)
                {
                    ePlant.Amount = Convert.ToInt32(txtAmount.Text);
                    count++;  //count = 4
                }
                else
                {
                    output = output + "\nEnter Valid Amount.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Amount.";
            }//end



            flag = false;
            bool flag2 = true;
            test = txtPrice.Text;               // ----------------------------------------------------------------------Update _ Price 
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
            if (flag && !string.IsNullOrEmpty(test) && flag2)
            {
                testDouble = Convert.ToDouble(txtPrice.Text);
                if (testDouble > 0)
                {
                    ePlant.Price = Convert.ToDouble(txtPrice.Text);
                    count++;
                }
                else
                {
                    output = output + "\nEnter Valid Price.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Price.";
            }//end



            if (count == 5) // --------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oplant.Update(ePlant);

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OPlant oPlant = new OPlant();

            if (oPlant.AvailablitiyPlantID(txtSearch.Text))
            {
                SqlDataAdapter sqlDataAdapter = oPlant.ReturnPlantIDInfo(txtSearch.Text);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataViewPlant.DataSource = dataTable;
            }
            else if (oPlant.AvailablitiyPlantName(txtSearch.Text))
            {
                SqlDataAdapter sqlDataAdapter = oPlant.ReturnPlantNameInfo(txtSearch.Text);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataViewPlant.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No Plant Found!");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new DashboardAdmin().Show();
            this.Hide();

        }
    }
}
