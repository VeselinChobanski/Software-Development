using _5.VegetablesShop;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.VegetablesShop.View
{
    internal class ViewShop
    {
        ControllerShop _controller;

        public ViewShop(ControllerShop controller)
        {
            _controller = controller;
        }
        public void Print()
        {
            double VegePerKg = double.Parse(Console.ReadLine());
            double FruitPerKg = double.Parse(Console.ReadLine());
            int VegKg = int.Parse(Console.ReadLine());
            int FruitKg = int.Parse(Console.ReadLine());

            double result = _controller.Info(new ModelShop(VegePerKg, FruitPerKg, VegKg, FruitKg));
            result /= 1.94;
            Console.WriteLine(result);
        }
    }
}
