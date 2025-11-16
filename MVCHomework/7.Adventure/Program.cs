namespace _7.Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicesAdv services = new ServicesAdv();
            ControllerAdv controller = new ControllerAdv(services);
            ViewAdv view = new ViewAdv(controller);
            view.Print();
        }
    }
}
