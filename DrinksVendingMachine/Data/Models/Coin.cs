using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksVendingMachine.Data.Models
{
    public class Coin
    {
        public int id { get; set; }
        public ushort value { get; set; }
        public bool available { get; set; }
        public ushort count { get; set; }
    }
}
