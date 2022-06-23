using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseryDataAccessLayer.Entities
{
   public class EOrder
    {
        private string orderId;
        private string orderStatus;
        private string customerId;
        private string plantId;
        private int plantAmount;
        private double totalPrice;


        public string OrderId
        {
            set;
            get;
        }

        public string OrderStatus
        {
            set;
            get;
        }

        public string CustomerId
        {
            set;
            get;
        }

        public string PlantId
        {
            set;
            get;
        }

        public int PlantAmount
        {
            set;
            get;
        }

        public double TotalPrice
        {
            set;
            get;
        }

    }
}
