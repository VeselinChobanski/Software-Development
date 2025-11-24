using _4.PasswordGenerator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PasswordGenerator
{
    public class ViewPassword
    {
        ControllerPassword _controller;

        public ViewPassword(ControllerPassword controller)
        {
            _controller = controller;
        }
        public void Print()
        {
            string n = Console.ReadLine();
            string l = Console.ReadLine();
            bool isCought = TryCatchEx(n,l);

            if (isCought == false)
            {
                Console.WriteLine(_controller.GetAllPassword(new ModelPassword(int.Parse(n), int.Parse(l))));
            }

           
        }

        public void ThowsEx(string n, string l )
        {
            int lInt = int.Parse(l);
            int nInt = int.Parse(n);
        }

        public bool TryCatchEx(string n, string l)
        {
            bool isCought = false;

            try
            {
                ThowsEx(n,l);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                isCought = true;
            }

            return isCought;

        }
    }
}
