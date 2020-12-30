using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application_Green_Quake
{
    public interface IAuth
    {
        Task<String> LoginWithEmailAndPassword(string email, string password);

        Task<String> SignUpWithEmailAndPassword(string email, string password);

        bool SignOut();

        bool IsSignIn();
    }
}
