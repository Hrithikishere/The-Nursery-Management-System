using NurseryDataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Operations
{
   public class OOrder
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9RFDGE4;Initial Catalog=TheNurseryManagementSystem;Integrated Security=True");
        public int Insert(EOrder eOrder)
        {


            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into TOrder([Order ID],[Order Status],[Customer ID],[Plant ID],[Plant Amount],[Total Price])values('" + eOrder.OrderId + "','" + eOrder.OrderStatus + "','" + eOrder.CustomerId + "','" + eOrder.PlantId + "','" + eOrder.PlantAmount + "','" + eOrder.TotalPrice + "')", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();
            return check;

        }

            public SqlDataAdapter Show()
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TOrder", connection);
                connection.Close();
                return sqlDataAdapter;
            }

            public int Update(EOrder eOrder)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update TOrder set [Order Status] = '" + eOrder.OrderStatus + "',[Customer ID] = '" + eOrder.CustomerId + "',[Plant ID] = '" + eOrder.PlantId + "',[Plant Amount] = '" + eOrder.PlantAmount + "',[Total Price] = '" + eOrder.TotalPrice + "' where [Order ID] = '" + eOrder.OrderId + "'", connection);
                int flag = cmd.ExecuteNonQuery();
                connection.Close();
                return flag;
            }
            public int Delete(EOrder  eOrder)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from TOrder where ID = '" + eOrder.OrderId + "'", connection);
                int flag = cmd.ExecuteNonQuery();
                connection.Close();
                return flag;
            }

        }

    }

