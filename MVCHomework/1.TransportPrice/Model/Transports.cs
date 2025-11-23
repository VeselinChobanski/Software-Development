namespace _1.TransportPrice
{
    public class Transports
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

    public class Taxi : Transports
    {
        public double TaxiStart { get; set; }
        public Taxi(double dayPrice, double nightPrice, int minDistance, double taxiStart) : base(dayPrice, nightPrice, minDistance)
        {
            TaxiStart = taxiStart;

        }
    }

    public class Bus : Transports
    {
        public Bus(double dayPrice, double nightPrice, int minDistance) : base(dayPrice, nightPrice, minDistance)
        {
            

        }
    }
    public class Train : Transports
    {
        public Train(double dayPrice, double nightPrice, int minDistance) : base(dayPrice, nightPrice, minDistance)
        {


        }
    }
}

