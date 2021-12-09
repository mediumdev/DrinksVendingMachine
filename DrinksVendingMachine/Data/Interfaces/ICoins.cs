using DrinksVendingMachine.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksVendingMachine.Data.Interfaces
{
    public interface ICoins
    {
        IEnumerable<Coin> Coins { get; set; }
        IEnumerable<Coin> GetAvailableCoins { get; set; }
        Coin GetCoinObject(int id);
    }
}
