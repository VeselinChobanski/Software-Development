namespace _9.MagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicesMagic services = new ServicesMagic();
            ControllerMagic controller = new ControllerMagic(services);
            ViewMagic view = new ViewMagic(controller);
            view.Display();
        }
    }
}
