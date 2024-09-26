using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Decorator
{
    internal class KakaoDecorator : KaffeeDecorator
    {
        Kaffee kaffee;
        public KakaoDecorator(Kaffee kaffee)
        {
            this.kaffee = kaffee;
            this.decorator_price = 0.5;
        }
        public override string getDescription()
        {
            return kaffee.getDescription() + " mit extra Kakaopulver ";
        }
        public override double getPrice()
        {
            return kaffee.getPrice() + decorator_price;         //Summe von Kaffee + Zusatz
        }
        
    }
}
