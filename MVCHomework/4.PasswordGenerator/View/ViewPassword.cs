using _4.PasswordGenerator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PasswordGenerator
{
    internal class ViewPassword
    {
        ControllerPassword _controller;

        public ViewPassword(ControllerPassword controller)
        {
            _controller = controller;
        }
        public void Print()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine(_controller.GetAllPassword(new ModelPassword(n,  l)));

            
        }
    }
}
