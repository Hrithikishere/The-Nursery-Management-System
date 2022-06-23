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
    public partial class OrderEmployee : Form
    {
        public OrderEmployee()
        {
            InitializeComponent();
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            new PlantEmployee().Show();
            this.Hide();

        }

        private void btnAboutOxygen_Click(object sender, EventArgs e)
        {
            About_Oxygen about_Oxygen = new About_Oxygen();
            about_Oxygen.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new OrderEmployee().Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new CustomerEmployee().Show();
            this.Hide();
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
            EOrder eOrder = new EOrder();
            OOrder oOrder = new OOrder();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck all sections!";
            double testDouble;
            int testInt;
            string test;
            bool flag;



            flag = false;
            test = txtOrderID.Text;                    // ---------------------------------------------------------Insert _ Order ID
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "O") && flag && (!oTesting.AvailablityOrderID(test)))  //IsNotNull? and 'O' in first
            {
                eOrder.OrderId = txtOrderID.Text;
                count++;  //count = 1
            }
            else
            {
                output = output + "\nEnter a unique and valid ID in Number, starts with O.";
            }//end



            if (rbtnPending.Checked)                        //-----------------------------------------------------Insert_orderStatus
            {
                eOrder.OrderStatus = rbtnPending.Text;
                rbtnInProcess.Checked = false;
                rbtnDelivered.Checked = false;
                count++;
            }
            else if (rbtnInProcess.Checked)
            {
                eOrder.OrderStatus = rbtnInProcess.Text;
                rbtnPending.Checked = false;
                rbtnDelivered.Checked = false;
                count++;
            }
            else if(rbtnDelivered.Checked)
            {
                eOrder.OrderStatus = rbtnDelivered.Text;
                rbtnPending.Checked = false;
                rbtnInProcess.Checked = false;
                count++;
            }
            else
            {
                output = output + "\nSelect OrderStatus.";
            }//end



            flag = false;
            test = txtCustomerID.Text;                    // -------------------------------------------------------Insert_Customer ID
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "C") && flag && (oTesting.AvailablityCustomerID(test)))  //IsNotNull? and 'O' in first
            {
                eOrder.CustomerId = txtCustomerID.Text;
                count++;  //count = 3
            }
            else
            {
                output = output + "\nEnter a valid Customer ID in Number starts with C.";
            }//end



            flag = false;
            test = txtPlantID.Text;                //-------------------------------------------------------------------Insert_PlantID
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "P") && flag && (oTesting.AvailablityPlantID(test)))  //IsNotNull? and 'O' in first
            {
                eOrder.PlantId = txtPlantID.Text;
                count++;  //count = 4
            }
            else
            {
                output = output + "\nEnter a valid Plant ID in Number, starts with P.";
            }//end



            flag = false;
            test = txtPlantAmount.Text;                 // --------------------------------------------------------Insert _ PlantAmount

            if (test.All(Char.IsDigit) && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testInt = Convert.ToInt32(txtPlantAmount.Text);   //Convert into double to check = 0 

                if (testInt > 0)
                {
                    eOrder.PlantAmount = Convert.ToInt32(txtPlantAmount.Text);
                    count++;  //count = 5
                }
                else
                {
                    output = output + "\nEnter Valid Plant Amount.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Plant Amount.";
            }//end



            flag = false;
            bool flag2 = true;
            test = txtTotalPrice.Text;               // ------------------------------------------------------------------Insert _ Price 
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
            if (flag && !string.IsNullOrEmpty(test) && flag2)   // all are integers and not null = 0
            {
                testDouble = Convert.ToDouble(txtTotalPrice.Text);   //Convert into double to check = 0 
                if (testDouble > 0)
                {
                    eOrder.TotalPrice = Convert.ToDouble(txtTotalPrice.Text);
                    count++;  //count = 5
                }
                else
                {
                    output = output + "\nEnter Valid Total Price.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Total Price.";
            }//end



            if (count == 6) // --------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oOrder.Insert(eOrder);

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
            OOrder oOrder = new OOrder();
            SqlDataAdapter sqlDataAdapter = oOrder.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataViewOrder.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EOrder eOrder = new EOrder();
            OOrder oOrder = new OOrder();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck entered ID!";
            double testDouble;
            int testInt;
            string test;
            bool flag;



            flag = false;
            test = txtOrderID.Text;                    // ------------------------------------------------------------Delete _ Order ID
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "O") && flag && (oTesting.AvailablityOrderID(test)))  //IsNotNull? and 'O' in first
            {
                eOrder.OrderId = txtOrderID.Text;
                count++;  //count = 1
            }
            else
            {
                output = output + "\nEnter a valid OrderID in Number starts with  O.";
            }//end



            if (count == 1) // --------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oOrder.Delete(eOrder);

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
            EOrder eOrder = new EOrder();
            OOrder oOrder = new OOrder();
            OTesting oTesting = new OTesting();

            int count = 0;  //9 = 9
            string output = "Please fill up or recheck all sections!";
            double testDouble;
            int testInt;
            string test;
            bool flag;



            flag = false;
            test = txtOrderID.Text;                    // ------------------------------------------------------------Update _ Order ID
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "O") && flag && (oTesting.AvailablityOrderID(test)))  //IsNotNull? and 'O' in first
            {
                eOrder.OrderId = txtOrderID.Text;
                count++;  //count = 1
            }
            else
            {
                output = output + "\nEnter a valid OrderID in Number starts with  O.";
            }//end



            if (rbtnPending.Checked)                        //------------------------------------------------------Update _orderStatus
            {
                eOrder.OrderStatus = rbtnPending.Text;
                rbtnInProcess.Checked = false;
                rbtnDelivered.Checked = false;
                count++;
            }
            else if (rbtnInProcess.Checked)
            {
                eOrder.OrderStatus = rbtnInProcess.Text;
                rbtnPending.Checked = false;
                rbtnDelivered.Checked = false;
                count++;
            }
            else if(rbtnDelivered.Checked)
            {
                eOrder.OrderStatus = rbtnDelivered.Text;
                rbtnPending.Checked = false;
                rbtnInProcess.Checked = false;
                count++;
            }
            else
            {
                output = output + "\nSelect OrderStatus.";
            }////end



            flag = false;
            test = txtCustomerID.Text;                    // ---------------------------------------------------Update_Customer ID
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "C") && flag && (oTesting.AvailablityCustomerID(test)))  //IsNotNull? and 'O' in first
            {
                eOrder.CustomerId = txtCustomerID.Text;
                count++;  //count = 3
            }
            else
            {
                output = output + "\nEnter a valid Customer ID in Number starts with  C.";
            }//end



            flag = false;
            test = txtPlantID.Text;                //-------------------------------------------------------------------Update_PlantID
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "P") && flag && (oTesting.AvailablityPlantID(test)))  //IsNotNull? and 'O' in first
            {
                eOrder.PlantId = txtPlantID.Text;
                count++;  //count = 4
            }
            else
            {
                output = output + "\nEnter a valid Plant ID in Number, starts with  P.";
            }//end



            flag = false;
            test = txtPlantAmount.Text;                 // ----------------------------------------------------------Update _ PlantAmount

            if (test.All(Char.IsDigit) && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testInt = Convert.ToInt32(txtPlantAmount.Text);   //Convert into double to check = 0 

                if (testInt > 0)
                {
                    eOrder.PlantAmount = Convert.ToInt32(txtPlantAmount.Text);
                    count++;  //count = 5
                }
                else
                {
                    output = output + "\nEnter valid Plant Amount.";
                }
            }
            else
            {
                output = output + "\nEnter valid Plant Amount.";
            }//end



            flag = false;
            bool flag2 = true;
            test = txtTotalPrice.Text;               // ------------------------------------------------------------------Update _ Price 
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
            if (flag && !string.IsNullOrEmpty(test) && flag2)   // all are integers and not null = 0
            {
                testDouble = Convert.ToDouble(txtTotalPrice.Text);   //Convert into double to check = 0 
                if (testDouble > 0)
                {
                    eOrder.TotalPrice = Convert.ToDouble(txtTotalPrice.Text);
                    count++;  //count = 5
                }
                else
                {
                    output = output + "\nEnter valid Total Price.";
                }
            }
            else
            {
                output = output + "\nEnter valid Total Price.";
            }//end



            if (count == 6) // --------------------------------------------------------------------------- all conditions are fullfilled
            {
                int check = oOrder.Update(eOrder);

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
            OOrder oOrder = new OOrder();

            if (oOrder.AvailablitiyOrderID(txtSearch.Text))
            {
                SqlDataAdapter sqlDataAdapter = oOrder.ReturnOrderIDInfo(txtSearch.Text);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataViewOrder.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No Order Found!");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new DashboardEmployee().Show();
            this.Hide();
        }
    }
}
