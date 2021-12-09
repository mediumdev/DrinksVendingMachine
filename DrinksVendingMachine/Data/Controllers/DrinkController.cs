using DrinksVendingMachine.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksVendingMachine.Data.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICoins coins;
        private readonly IDrinks drinks;

        public DrinkController(ICoins coins, IDrinks drinks)
        {
            this.coins = coins;
            this.drinks = drinks;
        }

        public ViewResult ListDrinks()
        {
            var allDrinks = drinks.GetAllDrinks;
            return View(allDrinks);
        }
    }
}
