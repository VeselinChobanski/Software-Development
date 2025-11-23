
namespace _1.TransportPrice
{
    public class ModelInput
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
