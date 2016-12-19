using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.drinks
{
    class espresso:DrinksBase
    {
        public override double GetCost()
        {
            return 25;
        }

        public espresso()
        {
            Desctiption = "Экспрессо";
        }
    }
}
