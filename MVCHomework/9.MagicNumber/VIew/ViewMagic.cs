using System;
using System.Collections.Generic;
using System.Text;

namespace _9.MagicNumber
{
    public class ViewMagic
    {
        ControllerMagic _controllerMagic;

        public ViewMagic(ControllerMagic controllerMagic)
        {
            _controllerMagic = controllerMagic;
        }

        public void Display()

        {
            string input = Console.ReadLine();
            bool isCought = TryCatchMagic(input);

            if (isCought == false)
            {
                Console.WriteLine(_controllerMagic.GetNumbers(new ModelMagic(int.Parse(input))));
            }
        }

        public void ThrowsExeptionsMagic(string number)
        {
            int inputInt = int.Parse(number);
        }

        public bool TryCatchMagic(string number)
        {
            bool isCpought = false;

            try
            {
                ThrowsExeptionsMagic(number);
            }
            catch(Exception ex)
            {
                isCpought = true;
                Console.WriteLine(ex.Message);
            }
            return isCpought;
                
        }

    }
}
