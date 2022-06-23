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
    public class OPlant
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9RFDGE4;Initial Catalog=TheNurseryManagementSystem;Integrated Security=True");
        public int Insert(EPlants ePlants)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into TPlants (Name, ID, Category, Amount, Price) values ('" + entPlants.Name + "','" + entPlants.Id + "','" + entPlants.Category + "','" + entPlants.Amount + "' ,'" + entPlants.Price + "')", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return check;
        }
        public SqlDataAdapter Show()
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TPlants", sqlConnection);
            sqlConnection.Close();
            return sqlDataAdapter;
        }

        public int Update(EntPlants entPlants)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("update TPlants set Name = '" + entPlants.Name + "', Category = '" + entPlants.Category + "', Amount = '" + entPlants.Amount + "', Price = '" + entPlants.Price + "' where ID = '" + entPlants.Id + "'", sqlConnection);
            int flag = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return flag;
        }
        public int Delete(EntPlants entPlants)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("delete from TPlants where ID = '" + entPlants.Id + "'", sqlConnection);
            int flag = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return flag;
        }
    }
}
