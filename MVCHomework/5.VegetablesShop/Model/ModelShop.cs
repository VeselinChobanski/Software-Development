using System;
using System.Collections.Generic;
using System.Text;

namespace _5.VegetablesShop
{
    internal class ModelShop
    {

        public double _pricePerKgVegetable;
        public double _pricePerKgFruit;
        public int _kgVegetable;
        public int _kgFruit;

        public ModelShop(double pricePerKgVegetable, double pricePerKgFruit, int kgVegetable, int kgFruit)
        {
            _pricePerKgVegetable = pricePerKgVegetable;
            _pricePerKgFruit = pricePerKgFruit;
            _kgVegetable = kgVegetable;
            _kgFruit = kgFruit;
        }
    }
}
