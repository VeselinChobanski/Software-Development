using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Adventure
{
    internal class ViewAdv
    {
        ControllerAdv _controller;
        public ViewAdv(ControllerAdv controller)
        {
            _controller = controller;
        }

        public void Print()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            Console.WriteLine(_controller.GetOutPut(new ModelAdv(budget, season)));
        }
    }
}
