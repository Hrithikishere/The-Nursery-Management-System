using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Entities
{
  public  class EUser
    {
        private String name;
        private String id;
        private String passwoard;
        private DateTime dob;
        private String gender;
        private String phone;
        private String adress;



        public string Name
        {
            set;
            get;
        }

        public string ID
        {
            set;
            get;
        }

        public string Password
        {
            set;
            get;
        }

        public DateTime DoB
        {
            set;
            get;
        }

        public string Gender
        {
            set;
            get;
        }

        public string Phone
        {
            set;
            get;
        }

        public string Address
        {
            set;
            get;
        }


    }
}
