using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Devide
{
    internal class ControllerDevide
    {
        ServicesDevide _service;

        public ControllerDevide(ServicesDevide service)
        {
            _service = service;
        }

        public string GetResult(ModelDevide model)
        {
            _service.Calculate(model);
            return _service.GetAll();
        }
    }
}
