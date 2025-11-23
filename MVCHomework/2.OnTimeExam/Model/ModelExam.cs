using System;
using System.Collections.Generic;
using System.Text;

namespace _2.OnTimeExam.Model
{
    public class ModelExam
    {
        public int ExamHour { get; set; }
        public int ExamMinute { get; set; }
        public int ArriveHour { get; set; }
        public int ArriveMinute { get; set; }

        public ModelExam(int examHour, int examMinute, int arriveHour, int arriveMinute)
        {
            ExamHour = examHour;
            ExamMinute = examMinute;
            ArriveHour = arriveHour;
            ArriveMinute = arriveMinute;
        }
    }
}
