using _4.PasswordGenerator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PasswordGenerator
{
    internal class ServicesPassword
    {
       List<string> _listOfPass;

        public ServicesPassword()
        {
            _listOfPass = new List<string>();
        }
        public List<string> GetAllPasswords(ModelPassword model)
        {
            string password = string.Empty;
            for(int i = 1; i < model.N; i++)
            {
                for (int j = 1; j < model.N; j++)
                {
                    for (int k = 97; k < 97 + model.L ; k++)
                    {
                        for (int p = 97; p <97 + model.L; p++)
                        {
                            int q = i;
                            if (j > q)
                            {
                                q = j;
                            } 
                            for (int h = q+1;  h < model.N; h++)
                            {
                                password = $"{i}{j}{(char)k}{(char)p}{h}";
                                _listOfPass.Add(password);
                            }
                        }

                    }
                }
            }
            return _listOfPass;
        }
    }
}
