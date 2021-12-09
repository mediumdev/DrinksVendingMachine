using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksVendingMachine.Data.Models
{
    public class Drink
    {
        public int id { get; set; }
        public string name { get; set; }
        public ushort price { get; set; }
        public ushort count { get; set; }
        public string image { get; set; }
    }
}
