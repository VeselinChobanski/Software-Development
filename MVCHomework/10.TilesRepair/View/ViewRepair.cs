using System;
using System.Collections.Generic;
using System.Text;

namespace _10.TilesRepair
{
    internal class ViewRepair
    {
        ControllerRepair _controller;

        public ViewRepair(ControllerRepair controller)
        {
            _controller = controller; 
        }

        public void Print()
        {
            int N = int.Parse(Console.ReadLine());
            double W = int.Parse(Console.ReadLine()); 
            double L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());
            Console.WriteLine(_controller.GetInfo(new ModelRepair(N,W,L,M,O)));
        }
    }
}
