using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.drinks
{
    public abstract class DrinksBase
    {
        protected string Desctiption = "";
        

        public string GetDesctiption()
        {
            return Desctiption;
        }
        
        public abstract double GetCost();
        
    }
}
