using System;
using System.Collections.Generic;
using System.Text;

namespace _1.TransportPrice.Model
{
    internal class ModelInput
    {
        public int Distance { get; set; }

        public string DayOrNight { get; set; }

        public ModelInput (int distance, string dayOrNight)
        {
            Distance = distance;
            DayOrNight = dayOrNight;
        }
    }
}
