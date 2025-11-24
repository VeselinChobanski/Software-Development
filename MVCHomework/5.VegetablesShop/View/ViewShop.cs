using _5.VegetablesShop;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.VegetablesShop.View
{
    public class ViewShop
    {
        ControllerShop _controller;

        public ViewShop(ControllerShop controller)
        {
            _controller = controller;
        }
        public void Print()
        {
            string VegePerKg = Console.ReadLine();
            string FruitPerKg = Console.ReadLine();
            string VegKg = Console.ReadLine();
            string FruitKg =Console.ReadLine();

            bool isCought = TryCatchExeptions(VegePerKg, FruitPerKg, VegKg, FruitKg);

            if (isCought == false)
            {
                double result = _controller.Info(new ModelShop(double.Parse(VegePerKg),double.Parse( FruitPerKg),int.Parse( VegKg), int.Parse(FruitKg)));
                result /= 1.94;
                Console.WriteLine(result);
            }



        }

        public void ThrowsExeptions(string vegePerKg, string fruitPerKg, string vegKg, string fruitKg)
        {
            double vegePerKgInd = double.Parse(vegePerKg);
            double fruitPerKgd = double.Parse(fruitPerKg);
            int vegKgInt = int.Parse(vegKg);
            int fruitKgInt = int.Parse(fruitKg);
        }

        public bool TryCatchExeptions(string vegePerKg, string fruitPerKg, string vegKg, string fruitKg)
        {
            bool isCought = false;
            try
            {
                ThrowsExeptions(vegePerKg,  fruitPerKg,  vegKg,  fruitKg);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                isCought = true;
            }

            return isCought;
        }
    }
}
