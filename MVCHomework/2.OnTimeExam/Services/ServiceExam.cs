using _2.OnTimeExam.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.OnTimeExam
{
    internal class ServiceExam
    {
        public string Output(ModelExam model)
        {
            int ExamTotalInMin = (model.ExamHour * 60) + model.ExamMinute;
            int ArriveTotalInMin = (model.ArriveHour * 60) + model.ArriveMinute;
            int diff = ArriveTotalInMin - ExamTotalInMin;

            if (diff > 0)
            {
                return $"Late {diff} ";
            }
            else if (diff >= -30)
            {
                return "On time";
            }
            else
            {
                return $"Early {diff}";
            }
        }

    }
}
