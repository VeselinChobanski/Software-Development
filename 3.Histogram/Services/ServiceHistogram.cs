using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Histogram;

internal class ServiceHistogram
{

    private List<double> _list;
    private double _p1;
    private double _p2;
    private double _p3;
    private double _p4;
    private double _p5;
    private double _count;

    public ServiceHistogram()
    {
        _list = new List<double>();
    }
    public void GetNumberOfP(ModelHistogram model)
    {
        _count =model.ListInput.Count;
        foreach (var item in model.ListInput)
        {
            if (item < 200)
            {
                _p1++;
            }
            else if (item >= 200 && item <= 399)
            {
                _p2 ++;
            }
            else if (item >= 400 && item <= 599)
            {
                _p3++;
            }
            else if (item >= 600 && item <= 799)
            {
                _p4++;
            }
            else
            {
                _p5 ++;
            }
        }
    }

    public List<double> GetResultCalc()
    {
        _list.Add(_p1 / _count * 100);
        _list.Add(_p2 / _count * 100);
        _list.Add(_p3 / _count * 100);
        _list.Add(_p4 / _count * 100);
        _list.Add(_p5 / _count * 100);

        return _list;
    }
}
