using _3.Histogram.View;

namespace _3.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHistogram histogram = new ServiceHistogram();
            ControllerHistogram controller = new ControllerHistogram(histogram);
            ViewHistogram viewHistogram = new ViewHistogram(controller);
            viewHistogram.PrintInfo();
        }
    }
}
