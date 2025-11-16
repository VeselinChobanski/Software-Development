namespace _4.PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicesPassword servicesPassword = new ServicesPassword();
            ControllerPassword controller = new ControllerPassword(servicesPassword);
            ViewPassword view = new ViewPassword(controller);
            view.Print();
        }
    }
}
