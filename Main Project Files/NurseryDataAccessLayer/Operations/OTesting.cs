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
  public  class OTesting
    {
        SqlConnection sqlConnection = SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9RFDGE4;Initial Catalog=TheNurseryManagementSystem;Integrated Security=True");
        public DataTable TestIDPasword(string id, string password)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TEmployee where ID = '" + id + "' and Password = '" + password + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public bool AvailablitiyIDPassword(string id, string password)
        {
            bool flag;

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TEmployee where ID = '" + id + "' and Password = '" + password + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                flag = true;
            }

            else
            {
                flag = false;
            }
            sqlConnection.Close();
            return flag;
        }

        public bool AvailablitiyIDPhone(string id, string phone)
        {
            bool flag;

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TEmployee where ID = '" + id + "' and Phone = '" + phone + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                flag = true;
            }

            else
            {
                flag = false;
            }
            sqlConnection.Close();
            return flag;
        }

        public DataTable TestIDPhone(string id, string phone)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TEmployee where ID = '" + id + "' and Phone = '" + phone + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public bool AvailablitiyEmployeeID(string id)
        {
            bool flag;

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TEmployee where ID = '" + id + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                flag = true;
            }

            else
            {
                flag = false;
            }
            sqlConnection.Close();
            return flag;
        }

        public bool AvailablitiyCustomerID(string id)
        {
            bool flag;

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TCustomer where ID = '" + id + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                flag = true;
            }

            else
            {
                flag = false;
            }
            sqlConnection.Close();
            return flag;
        }

        public bool AvailablitiyPlantID(string id)
        {
            bool flag;

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TPlants where ID = '" + id + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                flag = true;
            }

            else
            {
                flag = false;
            }
            sqlConnection.Close();
            return flag;
        }
    }
}
