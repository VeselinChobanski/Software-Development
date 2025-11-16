using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Devide
{
    internal class ServicesDevide
    {
        public List<double> result;

        public ServicesDevide()
        {
            result = new List<double>(); 
        }
        public List<double> Calculate(ModelDevide model)
        {
            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;

            foreach (var item in model.List)
            {
                if (item % 2 == 0)
                    countP1++;

                if (item % 3 == 0)
                    countP2++;

                if (item % 4 == 0)
                    countP3++;
            }

            double total = model.List.Count;

            double percP1 = (countP1 / total) * 100;
            double percP2 = (countP2 / total) * 100;
            double percP3 = (countP3 / total) * 100;

            result.Add(percP1);
            result.Add(percP2);
            result.Add(percP3);

            return result;
        }


        public string GetAll()
        {
            string input = "";
            foreach (var res in result)
            {
                input += $"{res:F2}%\n";
            }
            return input;
        }



    }
}
