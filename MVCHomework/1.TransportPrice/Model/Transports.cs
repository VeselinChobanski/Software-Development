using System;
using System.Collections.Generic;
using System.Text;

namespace _1.TransportPrice.Model
{
    internal class Transports
    {
        public double DayPrice { get; set; }
        public double NightPrice { get; set; }
        public int MinDistance { get; set; }

        public Transports(double dayPrice, double nightPrice, int minDistance)
        {
            DayPrice = dayPrice;
            NightPrice = nightPrice;
            MinDistance = minDistance;
        }
    }

    internal class Taxi : Transports
    {
        public double TaxiStart { get; set; }
        public Taxi(double dayPrice, double nightPrice, int minDistance, double taxiStart) : base(dayPrice, nightPrice, minDistance)
        {
            TaxiStart = taxiStart;

        }
    }

    internal class Bus : Transports
    {
        public Bus(double dayPrice, double nightPrice, int minDistance) : base(dayPrice, nightPrice, minDistance)
        {
            

        }
    }
    internal class Train : Transports
    {
        public Train(double dayPrice, double nightPrice, int minDistance) : base(dayPrice, nightPrice, minDistance)
        {


        }
    }
}

