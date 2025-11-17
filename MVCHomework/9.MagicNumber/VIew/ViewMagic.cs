using System;
using System.Collections.Generic;
using System.Text;

namespace _9.MagicNumber
{
    internal class ViewMagic
    {
        ControllerMagic _controllerMagic;

        public ViewMagic(ControllerMagic controllerMagic)
        {
            _controllerMagic = controllerMagic;
        }

        public void Display()

        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(_controllerMagic.GetNumbers(new ModelMagic(input)));
        }

    }
}
