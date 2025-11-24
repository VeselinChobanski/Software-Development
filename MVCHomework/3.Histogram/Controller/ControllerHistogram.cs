using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Histogram
{
    public class ControllerHistogram
    {
        ServiceHistogram _service;

        public ControllerHistogram(ServiceHistogram service)
        {
            _service = service;
        }
        public string ResultOutput(ModelHistogram model)
        {
            _service.GetNumberOfP(model);
            List<double> list = new List<double>();
            list = _service.GetResultCalc();
            string output = string.Empty;
            foreach (var item in list)
            {
                output += $"{item:F2}%\n";
            }

            return output ;
        }

    }
}
