using _1.TransportPrice.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.TransportPrice.Services
{
    internal class ControllerTransport
    {
        ServiceTransport _serviceTransport;

        public ControllerTransport(ServiceTransport serviceTransport)
        {
            _serviceTransport = serviceTransport;
        }

        public double Execute(ModelInput model)
        {
            _serviceTransport.CalculateAll(model);
           return _serviceTransport.ChooseOne();
        }

    }
}
