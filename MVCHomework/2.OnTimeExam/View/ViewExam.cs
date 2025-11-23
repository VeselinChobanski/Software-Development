using _2.OnTimeExam.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.OnTimeExam.View
{
    public class ViewExam
    {
        ControllerExam _controller;

        public ViewExam(ControllerExam controller)
        {
            _controller = controller;
        }
        public void PrintInfo()
        {
            string examHours = Console.ReadLine();
            string examMinites = Console.ReadLine();
            string arriveHours = Console.ReadLine();
            string arriveMinutes = Console.ReadLine();

            bool isExeptiont = TryCatchExeption(examHours, examMinites, arriveHours, arriveMinutes);
            if(isExeptiont == false)
            {
                Console.WriteLine(_controller.ExecuteResult(new ModelExam(int.Parse(examHours), int.Parse(examMinites), int.Parse(arriveHours), int.Parse(arriveMinutes))));
            }
        }

        public void ThrowsExeption( string examHours, string examMinites, string arriveHours, string arriveMinutes)
        {
            int examHoursInt = int.Parse(examHours);
            int examMinitesInt = int.Parse(examMinites);
            int arriveHoursInt = int.Parse(arriveHours);
            int arriveMinutesInt = int.Parse(arriveMinutes);

            if (examHoursInt < 0 || examMinitesInt < 0 || arriveHoursInt < 0 || arriveMinutesInt < 0)
            {
                throw new Exception("Negative input");
            }
        }

        public bool TryCatchExeption(string examHours, string examMinites, string arriveHours, string arriveMinutes)
        {
            bool isCountains = false;
            try
            {
                ThrowsExeption(examHours, examMinites, arriveHours, arriveMinutes);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                isCountains = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                isCountains = true;
            }
            return isCountains;
        }
    }
}
