namespace _10.TilesRepair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicesRepair services = new ServicesRepair(); 
            ControllerRepair controller = new ControllerRepair(services);
            ViewRepair view = new ViewRepair(controller);
            view.Print();
        }
    }
}
