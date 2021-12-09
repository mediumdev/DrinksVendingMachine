using DrinksVendingMachine.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksVendingMachine.Data.Interfaces
{
    public interface IDrinks
    {
        IEnumerable<Drink> GetAllDrinks { get; set; }
    }
}
