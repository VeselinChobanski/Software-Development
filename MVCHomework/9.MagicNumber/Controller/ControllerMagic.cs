using System;
using System.Collections.Generic;
using System.Text;

namespace _9.MagicNumber
{
    internal class ControllerMagic
    {

        ServicesMagic _servicesMagic;

        public ControllerMagic(ServicesMagic services) 
        {
            _servicesMagic = services;
        }

        public string GetNumbers(ModelMagic model)
        {
            List<int> magNumber = new List<int>();
            magNumber = _servicesMagic.Calculate(model);
            string output = "";
            foreach (var item in magNumber)
            {
                output += $"{item} ";
            }

            return output;
        }
    }
}
