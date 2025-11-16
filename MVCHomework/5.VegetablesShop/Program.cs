using _5.VegetablesShop.View;

namespace _5.VegetablesShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicesShop services = new ServicesShop();
            ControllerShop controller = new ControllerShop(services);
            ViewShop view = new ViewShop(controller);
            view.Print();
        }
    }
}
