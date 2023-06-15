using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322___Projekat
{
    class Order
    {
        public int? OrderId { get; set; }
        public int UserId { get; set; }
        public string RestorantName{ get; set; }
        public int Price { get; set; }
        public string Time { get; set; }

        public Order(int? orderId, int userId, string restorantName, int price, string time)
        {
            OrderId = orderId;
            UserId = userId;
            RestorantName = restorantName;
            Price = price;
            Time = time;
        }
        public Order() { }

    }
}
