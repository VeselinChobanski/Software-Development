using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Histogram;

internal class ModelHistogram
{

    public int N {  get; set; }
    public List<int> ListInput { get; set; }

    public ModelHistogram (int n, List<int> list)
    {
        N = n;
        ListInput = list;
    }
}
