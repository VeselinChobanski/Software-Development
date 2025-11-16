using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Pipe
{
    internal class ViewPipe
    {
        ControllerPipe _controller;

        public ViewPipe(ControllerPipe controller)
        {
            _controller = controller;
        }

        public void Print()
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine()); 
            int P2 = int.Parse(Console.ReadLine()); 
            double H = double.Parse(Console.ReadLine());

            Console.WriteLine(_controller.GetOutput(new ModelPipe(V,P1,P2,H)));
        }
    }
}
