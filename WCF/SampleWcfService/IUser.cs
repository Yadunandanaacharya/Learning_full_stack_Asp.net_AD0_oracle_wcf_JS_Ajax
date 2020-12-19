using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SampleWcfService
{
    [ServiceContract]
    public interface IUser
    {
        [OperationContract]
        string WelcomeUser(string username);

        [OperationContract]
        bool AuthenticateUserName(string username, string password);
    }
}
