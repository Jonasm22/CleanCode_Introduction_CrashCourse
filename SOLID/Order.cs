using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Order
    {
        public int Id { get; set; } 
        public string ProductName { get; set; }

        public string Quantity { get; set; }

        public double Price { get; set; }


    }
}
