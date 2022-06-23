using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDataAccessLayer.Entities
{
    public class ESales
    {
        private int totalSales;
        private int totalCustomers;
        private int totalPlants;
        
        public int TotalSale
        {
            set;
            get;
        }

        public int TotalCustomer
        {
            set;
            get;
        }

        public int TotalPlants
        {
            set;
            get;
        }
    }
}
