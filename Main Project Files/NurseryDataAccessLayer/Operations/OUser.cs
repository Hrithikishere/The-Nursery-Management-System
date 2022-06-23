using NurseryDataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Operations
{
   public abstract class OUser
    {
        public abstract int Insert(EEmployee eEmployee);

        //public abstract int Insert(EAdmin eAdmin);
    }
}
