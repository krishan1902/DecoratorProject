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
        }

        public override string getDescription()
        {
            return this.description;
        }

        public override double getPrice()
        {
            return 1;
        }
    }
}
