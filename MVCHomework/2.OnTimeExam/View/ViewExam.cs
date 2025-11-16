using _2.OnTimeExam.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.OnTimeExam.View
{
    internal class ViewExam
    {
        ControllerExam _controller;

        public ViewExam(ControllerExam controller)
        {
            _controller = controller;
        }
        public void PrintInfo()
        {
            int ExamHours = int.Parse(Console.ReadLine());
            int ExamMinites = int.Parse(Console.ReadLine());
            int ArriveHours = int.Parse(Console.ReadLine());
            int ArriveMinutes = int.Parse(Console.ReadLine());

            Console.WriteLine(_controller.ExecuteResult(new ModelExam(ExamHours, ExamMinites, ArriveHours, ArriveMinutes)));
        }
    }
}
