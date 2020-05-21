using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Item
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
