using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Adventure
{
    public class ControllerAdv
    {

        ServicesAdv _servicesAdv;

        public ControllerAdv(ServicesAdv servicesAdv)
        {
            _servicesAdv = servicesAdv;
        }

        public string GetOutPut(ModelAdv model)
        {
            return _servicesAdv.Calculate(model);
        }
    }
}
