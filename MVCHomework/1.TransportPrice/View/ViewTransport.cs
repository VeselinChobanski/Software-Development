namespace _1.TransportPrice
{
    public class ViewTransport
    {

        ControllerTransport controller;
        
        public ViewTransport()
        {
            controller = new ControllerTransport(new ServiceTransport());
        }
        public void Display()
        {
            string distance = Console.ReadLine();
            string dayOrNight = Console.ReadLine();
            bool counEx = TryCatchExeptions(distance,dayOrNight);

            if (counEx == false)
            {
                Console.WriteLine(controller.Execute(new ModelInput(int.Parse(distance), dayOrNight)));
            }
        }
        public void ThrowException(string distance, string dayOrNight)
        {
            int distanceInt = int.Parse(distance);

            if (distanceInt < 0)
            {
                throw new Exception("Negative distance");
            }
            else if (dayOrNight.ToLower() != "day" && dayOrNight.ToLower() != "night")
            {
                throw new Exception("No day or night");
            }
        }

        public bool TryCatchExeptions(string distance, string dayOrNight)
        {
            bool isCought = false;
            try
            {
                ThrowException(distance, dayOrNight);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                isCought = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isCought= true;
            }

            return isCought;
        }
     
    }


}
