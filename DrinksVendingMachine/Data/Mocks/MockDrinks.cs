using DrinksVendingMachine.Data.Interfaces;
using DrinksVendingMachine.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksVendingMachine.Data.Mocks
{
    public class MockDrinks : IDrinks
    {
        public IEnumerable<Drink> GetAllDrinks
        {
            get
            {
                return new List<Drink>
                {
                    new Drink { image = "Cola", count = 50, price = 58 },
                    new Drink { image = "Fanta", count = 40, price = 46 }
                };
            }
            set
            {

            }
        }
    }
}
