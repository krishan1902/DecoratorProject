using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Decorator
{
    internal abstract class KaffeeDecorator : Kaffee
    {
        protected double decorator_price;
    }
}
