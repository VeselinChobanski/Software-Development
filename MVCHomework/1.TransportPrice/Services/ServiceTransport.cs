
namespace _1.TransportPrice
{
    public class ServiceTransport
    {
        public Taxi taxi = new Taxi(0.79, 0.90, 0, 0.70);
        public Transports bus = new Bus(0.09, 0.09, 20);
        public Transports train = new Train(0.06, 0.06, 100);

        List<double> list;

        public double result;

        public ServiceTransport()
        {
            list = new List<double>();
        }
        public void CalculateAll(ModelInput model)
        {

            bool IsDay = false;
            double result;
            if (model.DayOrNight == "day")
            {
                IsDay = true;
            }

            //Taxi
            if (bus.MinDistance > model.Distance)
            {
                if (IsDay == true)
                {
                    result = taxi.TaxiStart + (model.Distance * taxi.DayPrice);
                }
                else
                {
                    result = taxi.TaxiStart + (model.Distance * taxi.NightPrice);
                }
                list.Add(result);
            }

            //Bus
            if (train.MinDistance > model.Distance)
            {
                if (IsDay == true)
                {
                    result = model.Distance * bus.DayPrice;
                }
                else
                {
                    result = model.Distance * bus.NightPrice;
                }
                list.Add(result);
            }
            //Train
            if (model.Distance > train.MinDistance)
            {
                if (IsDay == true)
                {
                    result = model.Distance * train.DayPrice;
                }
                else
                {
                    result = model.Distance * train.NightPrice;
                }
                list.Add(result);
            }
        }

        public double ChooseOne()
        {
            double finalRes = list[0];
            foreach (var item in list)
            {
                if (item > finalRes)
                {
                    finalRes = item;
                }
            }

            return finalRes;
        }
    }
}
