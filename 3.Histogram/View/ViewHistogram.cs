using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Histogram.View;

internal class ViewHistogram
{
    ControllerHistogram _controller;

    public ViewHistogram(ControllerHistogram controller)
    {
        _controller = controller;
    }

    public void PrintInfo()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> listModel = new List<int>();
        for (int i = 0; i < n; i++)
        {
            listModel.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine($"{_controller.ResultOutput(new ModelHistogram(n, listModel))}");
        

    }
}
