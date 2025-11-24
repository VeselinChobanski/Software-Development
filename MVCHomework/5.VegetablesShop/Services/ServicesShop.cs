using _5.VegetablesShop;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.VegetablesShop
{
    public class ServicesShop
    {

        public double CalculatePrice(ModelShop model)
        {
            double total = (model._pricePerKgVegetable * model._kgVegetable) + (model._pricePerKgFruit * model._kgFruit);
            return total;
        }
    }
}
