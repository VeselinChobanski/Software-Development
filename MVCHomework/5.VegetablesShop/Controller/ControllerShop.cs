using _5.VegetablesShop;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.VegetablesShop
{
    internal class ControllerShop
    {
        ServicesShop _services;

        public ControllerShop (ServicesShop services)
        {
           _services = services;
        }

        public double Info(ModelShop model)
        {
             return _services.CalculatePrice(model);
        }
    }
}
