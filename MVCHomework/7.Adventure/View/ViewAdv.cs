using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Adventure
{
    public class ViewAdv
    {
        ControllerAdv _controller;
        public ViewAdv(ControllerAdv controller)
        {
            _controller = controller;
        }

        public void Print()
        {
            string budget = Console.ReadLine();
            string season = Console.ReadLine();
            bool isCought = TryCatchExeptionAdv(budget, season);

            if (isCought == false)
            {
                Console.WriteLine(_controller.GetOutPut(new ModelAdv(double.Parse(budget), season)));
            }

            
        }

        public void ThrowsExeptionAdv(string budget, string season)
        {
            double budgetDouble = double.Parse(budget);

            if (season != "summer" && season != "winter")
            {
                throw new Exception("No valid season");
            }
            else if (budgetDouble < 1)
            {
                throw new Exception("Negative budget");

            }
        }

        public bool TryCatchExeptionAdv(string budget, string season)
        {
            bool isCought = false;

            try
            {
                ThrowsExeptionAdv(budget, season);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                isCought = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                isCought = true;
            }

            return isCought;
        }
    }
}
