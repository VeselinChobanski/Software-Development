using _2.OnTimeExam.View;

namespace _2.OnTimeExam
{
    public class Program
    {
        static void Main(string[] args)
        {

           ServiceExam service = new ServiceExam(); 
           ControllerExam controller = new ControllerExam(service);
            ViewExam view = new ViewExam(controller);

            view.PrintInfo();
        }
    }
}
