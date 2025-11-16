using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Devide
{
    internal class VeiwDevide
    {

        ControllerDevide _controller;

        public VeiwDevide(ControllerDevide controller)
        {
            _controller = controller;
        }

        public void Print()
        {
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(_controller.GetResult(new ModelDevide(n, list)));

        }
    }
}
