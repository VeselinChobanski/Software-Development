using _2.OnTimeExam.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.OnTimeExam
{
    public class ControllerExam
    {
        ServiceExam _service;

        public ControllerExam(ServiceExam service)
        {
            _service = service;
        }
        public string ExecuteResult(ModelExam model)
        {
             return _service.Output(model);
        }
    }
}
