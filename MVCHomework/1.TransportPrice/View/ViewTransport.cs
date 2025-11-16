using _1.TransportPrice.Model;
using _1.TransportPrice.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _1.TransportPrice.View
{
    internal class ViewTransport
    {

        ControllerTransport service;
        
        public ViewTransport()
        {
            service = new ControllerTransport(new ServiceTransport());
        }
        public void Display()
        {
            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            Console.WriteLine(service.Execute(new ModelInput(distance, dayOrNight)));
            
        }
     
    }
}
