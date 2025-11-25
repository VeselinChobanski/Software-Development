using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Pipe
{
    public class ViewPipe
    {
        ControllerPipe _controller;

        public ViewPipe(ControllerPipe controller)
        {
            _controller = controller;
        }

        public void Print()
        {
            string V = Console.ReadLine();
            string P1 = Console.ReadLine(); 
            string P2 = Console.ReadLine(); 
            string H = Console.ReadLine();

            bool isCought = TryCatchExeptionsPipe(V,P1,P2,H);
            if(isCought == false)
            {
                Console.WriteLine(_controller.GetOutput(new ModelPipe(int.Parse(V), int.Parse(P1), int.Parse(P2), double.Parse(H))));
            }

            
        }
        public void ThrowsExeptionsPipe(string res1, string res2, string res3, string res4)
        {
            int res1Int = int.Parse(res1);
            int res2Int = int.Parse(res2);
            int res3Int = int.Parse(res3);
            double res4Int = int.Parse(res4);
            if (res1Int < 0 || res2Int < 0 || res3Int < 0 || res4Int < 0)
            {
                throw new Exception("Negative number");
            }
        }

        public bool TryCatchExeptionsPipe(string res1, string res2, string res3, string res4)
        {
            bool isCought = false;

            try
            {
                ThrowsExeptionsPipe( res1,  res2,  res3,  res4);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                isCought = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isCought = true;
            }

            return isCought;
        }
    }
}
