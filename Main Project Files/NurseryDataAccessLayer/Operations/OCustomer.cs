using NurseryDataAccessLayer.Entities;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Operations
{
  
    public class OCustomer
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9RFDGE4;Initial Catalog=TheNurseryManagementSystem;Integrated Security=True");
        public int Insert(ECustomer eCustomer)
        {

            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into TCustomer(Name,ID,Gender,Address,Phone)values('" + eCustomer.Name + "','" + eCustomer.Id + "','" + eCustomer.Gender + "','" + eCustomer.Address + "','" + eCustomer.Phone + "')", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();
            return check;

        }

         public SqlDataAdapter Show()

            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TCustomer",  connection);
                connection.Close();
                return sqlDataAdapter;
            }

            public int Update(ECustomer eCustomer)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update TCustomer set Name = '" + eCustomer.Name + "', Gender = '" + eCustomer.Gender + "', Address = '" + eCustomer.Address + "', Phone = '" + eCustomer.Phone + "' where ID = '" + eCustomer.Id + "'", connection);
                int flag = cmd.ExecuteNonQuery();
                connection.Close();
                return flag;
            }

            public int Delete(ECustomer entCustomer)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from TCustomer where ID = '" + entCustomer.Id + "'", connection);
                int flag = cmd.ExecuteNonQuery();
                connection.Close();
                return flag;
            }



        }
    }

