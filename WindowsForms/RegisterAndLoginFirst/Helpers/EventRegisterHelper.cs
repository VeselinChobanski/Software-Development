using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterAndLoginFirst.Helpers;

public static class EventRegisterHelper
{
    public static bool IsEverythingWriten(string txtUsername, string txtPassword, string txtConfirmPassword)
    {
        if (string.IsNullOrEmpty(txtUsername)||
            string.IsNullOrEmpty(txtPassword)||
            string.IsNullOrEmpty(txtConfirmPassword))
        {
            return false;
        }

        return true;  
    }

    public static bool IsPasswordsCorrectLength(string txtPassword, string txtConfirmPassword)
    {
        if (txtPassword.Length < 6 ||
     txtConfirmPassword.Length < 6)
        {
            return false;
        }
        return true;
    }

    public static bool IsPasswordsMatched(string txtPassword, string txtConfirmPassword)
    {
        if (txtPassword != txtConfirmPassword)
        {
            return false;
        }
        return true;
    }

}
