using DrinksVendingMachine.Data.Interfaces;
using DrinksVendingMachine.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksVendingMachine.Data.Mocks
{
    public class MockCoins : ICoins
    {
        public IEnumerable<Coin> Coins
        {
            get
            {
                return new List<Coin>
                {
                    new Coin {value = 1, count = 50, available = true },
                    new Coin {value = 2, count = 30, available = true },
                    new Coin {value = 5, count = 20, available = true },
                    new Coin {value = 10, count = 10, available = true }
                };
            }
            set => throw new NotImplementedException();
        }
        public IEnumerable<Coin> GetAvailableCoins { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Coin GetCoinObject(int id)
        {
            throw new NotImplementedException();
        }
    }
}
