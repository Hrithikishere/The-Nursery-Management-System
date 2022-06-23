using NurseryDataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Operations
{
    public  class OEmployee : OUser
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9RFDGE4;Initial Catalog=TheNurseryManagementSystem;Integrated Security=True");
        public override int Insert(EEmployee eEmployee)

        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into TEmployee (Name, ID, Gender, [Date of Birth], Phone, Address,Role, Salary, Passwoard) values ('" + eEmployee.Name + "','" + eEmployee.ID + "','" + eEmployee.Gender + "','" + eEmployee.DoB + "' ,'" + eEmployee.Phone + "' ,'" + eEmployee.Address + "' ,'" + eEmployee.Role + "' ,'" + eEmployee.Salary + "' ,'" + eEmployee.Password + "')", connection);
            int check = sqlCommand.ExecuteNonQuery();
            connection.Close();
            return check;
        }

        public SqlDataAdapter Show()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TEmployee", connection);
            connection.Close();
            return sqlDataAdapter;
        }


        public int Update(EEmployee eEmployee)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update TOrder set Name = '" + eEmployee.Name + "',  Gender = '" + eEmployee.Gender + "', [Date of Birth] = '" + eEmployee.DoB + "', Phone = '" + eEmployee.Phone + "', Address = '" + eEmployee.Address + "', Role = '" + eEmployee.Role + "', Salary = '" + eEmployee.Salary + "',  Passwoard = '" + eEmployee.Password + "' where ID = '" + eEmployee.ID + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
        public int Delete(EEmployee eEmployee)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from TEmployee where ID = '" + eEmployee.ID + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }





    }
}
