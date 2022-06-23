using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Entities
{
 public   class EPlants
    {
        private String name;
        private String id;
        private String category;
        private int amount;
        private double price;


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

        public string Category
        {
            set;
            get;
        }

        public int Amount
        {
            set;
            get;
        }

        public double Price
        {
            set;
            get;
        }
    }
}
