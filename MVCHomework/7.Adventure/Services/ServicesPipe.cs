using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _7.Adventure
{
    internal class ServicesAdv
    {
        public string Calculate(ModelAdv model)
        {
            string type;
            string destination;
            double tax = 0;
            if (model.Budget <= 100)
            {
                destination = "Bulgaria";
                if (model.Season == "winter")
                {
                    tax = 0.7;
                }
                else
                {
                    tax = 0.3;
                }

            }
            else if (model.Budget <= 1000)
            {
                destination = "Balkans";
                if (model.Season == "winter")
                {
                    tax = 0.8;
                }
                else
                {
                    tax = 0.4;
                }
            }
            else
            {
                destination = "Europe";
                tax = 0.9;
            }
            if (destination != "Europe")
            {
                if (model.Season == "summer")
                {
                    type = "Camp";
                }
                else
                {
                    type = "Hotel";
                }
            }
            else
            {
                type = "Hotel";
            }
            double result = (tax * model.Budget);
            string output = $"Somewhere in {destination}\n";
            output += $"{type} – {result}";
            return output;
        }

    }
}
