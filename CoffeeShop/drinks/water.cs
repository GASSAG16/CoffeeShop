using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.drinks
{
    class water:DrinksBase
    {
        public override double GetCost()
        {
            return 0;
        }

        public water()
        {
            Desctiption = "Вода";
        }



    }
}
