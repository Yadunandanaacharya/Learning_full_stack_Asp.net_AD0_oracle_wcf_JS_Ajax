using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace SampleWcfWebService
{
    public class User : IUser, IUsers
    {
        public bool AuthenticateUserName(string username, string password)
        {
            if (username == "wcf" && password == "tutorials")

                return true;
            else
                return false;

        }

        public List<string> GetUserNames()
        {
            return new List<string>();
        }

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
    }
}
