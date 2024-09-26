using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_Decorator
{
    internal class SchwarzerKaffee : Kaffee
    {   
        
        public SchwarzerKaffee()
        {
            this.description = "Schwarzer Kaffee";
            this.price = 1;
        }

        public override string getDescription()
        {
            return this.description;
        }

        public override double getPrice()
        {
            return this.price;
        }
    }
}
