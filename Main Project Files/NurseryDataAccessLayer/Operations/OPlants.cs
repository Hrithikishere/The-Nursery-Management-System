using NurseryDataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Operations
{
    public class OPlants
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9RFDGE4;Initial Catalog=TheNurseryManagementSystem;Integrated Security=True");
        public int Insert(EPlants ePlants)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into TPlant(Name,ID,Category,Amount,Price)values('" + ePlants.Name + "','" + ePlants.Id + "','" + ePlants.Category + "','" + ePlants.Amount + "','" + ePlants.Price + "')", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();
            return check;
        }
            public SqlDataAdapter Show()
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TPlant", connection);
                connection.Close();
                return sqlDataAdapter;
            }

            public int Update(EPlants entPlants)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update TPlant set Name = '" + entPlants.Name + "', Category = '" + entPlants.Category + "', Amount = '" + entPlants.Amount + "', Price = '" + entPlants.Price + "' where ID = '" + entPlants.Id + "'", connection);
                int flag = cmd.ExecuteNonQuery();
                connection.Close();
                return flag;
            }
            public int Delete(EPlants entPlants)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from TPlant where ID = '" + entPlants.Id + "'", connection);
                int flag = cmd.ExecuteNonQuery();
                connection.Close();
                return flag;
            }

        }
      }
    

