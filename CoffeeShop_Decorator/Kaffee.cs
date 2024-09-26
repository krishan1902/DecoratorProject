using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Decorator
{
    internal abstract class Kaffee
    {
        protected string description;
        protected double price;
        
        public abstract string getDescription();
        public abstract double getPrice();
    }
}
