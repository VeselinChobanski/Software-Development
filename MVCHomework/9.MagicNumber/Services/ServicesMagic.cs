using System;
using System.Collections.Generic;
using System.Text;

namespace _9.MagicNumber
{
    internal class ServicesMagic
    {
        public List<int> Result;

        public ServicesMagic()
        {
            Result = new List<int>();
        }

        public List<int> Calculate(ModelMagic model)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            for (int o = 0; o < 9; o++)
                            {
                                for (int q = 0; q < 9; q++)
                                {
                                    if (i*j*k*l*o*q == model.Number)
                                    {
                                        string magNum = $"{i}{j}{k}{l}{o}{q}";
                                        Result.Add(int.Parse(magNum));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return Result;
        }
    }
}
