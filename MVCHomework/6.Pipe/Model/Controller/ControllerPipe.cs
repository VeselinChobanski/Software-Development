using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Pipe
{
    public class ControllerPipe
    {
        ServicesPipe _service;

        public ControllerPipe(ServicesPipe service)
        {
            _service = service;
        }

        public string GetOutput(ModelPipe model)
        {
            return _service.CalculatePercentage(model);
        }
    }
}
