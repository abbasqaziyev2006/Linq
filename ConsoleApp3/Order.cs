using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    public class Order
    {
        public int Id { get; set; }
        public required string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Ad: {CustomerName}, Mebleg: ${Amount}, Tarix: {OrderDate}";
        }
    }
}


