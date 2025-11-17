using System;
using System.Collections.Generic;
using System.Text;

namespace _10.TilesRepair
{
    internal class ControllerRepair
    {

        ServicesRepair _services;
        public ControllerRepair(ServicesRepair services)
        {
            _services = services;
        }

        public string GetInfo(ModelRepair model)
        {
            List<double> list = new List<double>();
            list = _services.CalculateResult(model);
            string output = "";
            foreach (double item in list)
            {
                output += $"{item}\n";
            }
            return output;
        }
    }
}
