using _4.PasswordGenerator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PasswordGenerator
{
    internal class ControllerPassword
    {

        ServicesPassword _services;

        public ControllerPassword(ServicesPassword services)
        {
            _services = services;
        }
        public string GetAllPassword(ModelPassword model)
        {
            string AllPass = "";

            List<string> passwordsList = new List<string>();

            passwordsList = _services.GetAllPasswords(model);

            foreach (string password in passwordsList)
            {
                AllPass += $"{password} ";
            }

            return AllPass;
        }
    }
}
