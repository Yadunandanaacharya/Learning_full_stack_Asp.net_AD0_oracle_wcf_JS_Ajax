using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace samplewcfservice
{
    [ServiceContract]
    public interface IUser
    {
        [OperationContract]
        string WelcomeUser(string username);

        [OperationContract]
        bool AuthenticateUser(string username, string password);
    }
}
