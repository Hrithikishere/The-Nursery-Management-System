using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Entities
{
    class EAdmin : EUser
    {
        private String managementLevel;

        public String ManagementLevel

        {
            set;
            get;
        }

    }
}
