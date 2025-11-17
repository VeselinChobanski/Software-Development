using System;
using System.Collections.Generic;
using System.Text;

namespace _10.TilesRepair
{
    internal class ServicesRepair
    {

        public List<double> CalculateResult(ModelRepair model)
        {
            List<double> list = new List<double>();

            int S = model.N * model.N;
            int S2 = model.M * model.O;
            int SNew = S - S2;
            double STiles = model.W * model.L;

            double outPut1 = SNew/STiles;
            double outPut2 = outPut1*0.2;

            list.Add(outPut1);
            list.Add(outPut2);

            return list;
        } 
    }
}
