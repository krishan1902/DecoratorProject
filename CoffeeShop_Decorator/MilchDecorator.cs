using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Decorator
{
    internal class MilchDecorator : KaffeeDecorator
    {
        Kaffee decorating_kaffee;
        public MilchDecorator(Kaffee kaffee)
        {
            this.decorating_kaffee = kaffee;
            this.decorator_price = 0.6;
        }

        public override string getDescription()
        {
            return decorating_kaffee.getDescription() + " mit extra Milch";
        }
        public override double getPrice()
        {
           return decorating_kaffee.getPrice() + decorator_price;      //Summe von Kaffee + Zusatz
        }
    }
}
