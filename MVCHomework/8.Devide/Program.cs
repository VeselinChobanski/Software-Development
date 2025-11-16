namespace _8.Devide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicesDevide services = new ServicesDevide();
            ControllerDevide controller = new ControllerDevide(services);
            VeiwDevide veiw = new VeiwDevide(controller);
            veiw.Print();
        }
    }
}
