using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Entities
{
  public class EEmployee : EUser
    {
        private string role;
        private double salary;


        public string Role

        {
            set;
            get;
        }

        public double Salary
        {
            set;
            get;
        }



    }
}
