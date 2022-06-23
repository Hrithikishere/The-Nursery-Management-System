using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Entities
{
   public class ECustomer
    {
        private String name;
        private String id;
        private String gender;
        private int address;
        private double phone;

        public string Name
        {
            set;
            get;
        }

        public string Id
        {
            set;
            get;
        }

        public string Gender
        {
            set;
            get;
        }

        public string Address
        {
            set;
            get;
        }

        public double Phone
        {
            set;
            get;
        }

    }
}
