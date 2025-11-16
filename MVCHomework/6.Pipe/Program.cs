namespace _6.Pipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicesPipe services = new ServicesPipe();
            ControllerPipe controller = new ControllerPipe(services);
            ViewPipe view = new ViewPipe(controller);
            view.Print();
        }
    }
}
