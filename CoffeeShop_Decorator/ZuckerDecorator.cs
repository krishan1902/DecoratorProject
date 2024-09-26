using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Decorator
{
    internal class ZuckerDecorator : KaffeeDecorator
    {
        Kaffee decoratingKaffee;
        public ZuckerDecorator(Kaffee kaffee)
        {
            this.decoratingKaffee = kaffee;
            this.decorator_price = 0.4;
        }
        public override string getDescription()
        {
            return decoratingKaffee.getDescription() + " mit extra Zucker";
        }
        public override double getPrice()
        {
            return decoratingKaffee.getPrice() + decorator_price;   //Summe von Kaffee + Zusatz
        }
    }
}
