using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Histogram.View
{
    public class ViewHistogram
    {
        ControllerHistogram _controller;

        public ViewHistogram(ControllerHistogram controller)
        {
            _controller = controller;
        }

        public void PrintInfo()
        {
            string n = Console.ReadLine();
            List<string> listModel = new List<string>();
            bool coughtExN = TryCatchCheckN(n);
            if (coughtExN == false)
            {
                for (int i=0; i < int.Parse(n);  i++)
                {
                    listModel.Add(Console.ReadLine());
                }
            }

            List<int> listInt = new List<int>();
            bool coughtExList = TryCatchCheckList(listModel);
            if (coughtExList == false)
            {
                foreach(var item in listModel)
                {
                    listInt.Add(int.Parse(item));
                }
            }

           if(coughtExN == false && coughtExList == false)
            {
                Console.WriteLine($"{_controller.ResultOutput(new ModelHistogram(int.Parse(n), listInt))}");
            }
            

        }
        public void ThrowsExeptionsN(string n )
        {
            int nInt = int.Parse(n);
            if (nInt < 1)
            {
                throw new Exception("Negative N");
            }
        }
        public void ThrowsExeptionsList( List<string> numbers)
        {
          
           foreach (var item in numbers)
            {
                int num = int.Parse(item);
            }

            
        }

        public bool TryCatchCheckList( List<string> numbers)
        {
            bool coughtEx = false;
            try
            {
                ThrowsExeptionsList(numbers);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                coughtEx = true;
            }

            return coughtEx;
        }

        public bool TryCatchCheckN(string n)
        {
            bool coughtEx = false;
            try
            {
                ThrowsExeptionsN(n);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                coughtEx = true;
            }

            return coughtEx;
        }
    }
}
