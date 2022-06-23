using NurseryDataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Operations
{
    public class OSales
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9RFDGE4;Initial Catalog=TheNurseryManagementSystem;Integrated Security=True");
        public int totalSales()
        {
            int sales;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select SUM ([Total Price]) from TOrder where [Order Status] = 'Delivered'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sales = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            sqlConnection.Close();
            return sales;
        }

        public int TotalCustomer()
        {
            int sales;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select COUNT(ID) from TCustomer", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sales = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            sqlConnection.Close();
            return sales;
        }

        public int TotalEmployee()
        {
            int sales;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select COUNT(ID) from TEmployee", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sales = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            sqlConnection.Close();
            return sales;
        }

        public int TotalOrder()
        {
            int sales;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select COUNT([Order ID]) from TOrder", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sales = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            sqlConnection.Close();
            return sales;
        }

        public int TotalPlants()
        {
            int sales;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select COUNT(ID) from TPlants", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sales = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            sqlConnection.Close();
            return sales;
        }

        /*
         * 
        public int Insert(EntOrder entOrder)
        {
            
            return check;
        }
         */
    }
}
