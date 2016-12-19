using CoffeeShop.drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.decorator
{
    class addSugarPrice:supplementsBase
    {
        private DrinksBase _drinks;

        public addSugarPrice(DrinksBase drinks)
        {
            _drinks = drinks;
            Desctiption = _drinks.GetDesctiption() + " + "+" Сахар ";
        }

       public override double GetCost()
       {
          return _drinks.GetCost() + 10;
       }

    }
}
