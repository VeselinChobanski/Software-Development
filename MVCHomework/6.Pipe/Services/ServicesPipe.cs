using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Pipe
{
    public class ServicesPipe
    {

        public string CalculatePercentage(ModelPipe model)
        {

            string output = "";
            double firstPipeTotal = model.P1 * model.H;
            double secondPipeTotal = model.P2 * model.H;
            double sum = firstPipeTotal + secondPipeTotal;
            if (sum < model.V)
            {
                double totalPercentage = sum / model.V * 100;
                double Pipe1 = firstPipeTotal/ sum * 100;
                double Pipe2 = secondPipeTotal / sum * 100;
                 output = $"The pool is {totalPercentage}% full. Pipe 1: {Pipe1:F2}%. Pipe 2: {Pipe2:F2}%.";
                
            }
            else
            {
                output = $"For {model.H} hours the pool overflows with {sum} liters.";
                
            }
            return output;

        }
    }
}
