using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace samplewcfservice
{
    public class User : IUser
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (username == "wcf" && password == "tutorials")

                return true;
            else
                return false;
    
        }

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
    }
}
