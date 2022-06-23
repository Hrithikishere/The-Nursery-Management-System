using PreDataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Operations
{
    public class OAboutMeEmployee
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-81AAC3B;Initial Catalog=PreNurseryManagementSystem;Integrated Security=True");
        public int Store(string id)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into TAboutMe (ID) values ('" + id + "')", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return check;
        }
        public DataTable AboutMe()
        {
            string id;
            bool flag;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TAboutMe", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
           
            id = dataTable.Rows[0][0].ToString();

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("Select * from TEmployee where ID = '" + id + "'", sqlConnection);
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);

            SqlCommand sqlCommand = new SqlCommand("delete from TAboutMe where ID = '" + id + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return dataTable2;
        }

    }
}
