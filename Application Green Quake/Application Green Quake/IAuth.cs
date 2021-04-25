using System;
using System.Threading.Tasks;

namespace Application_Green_Quake
{
    public interface IAuth
    {
        Task<String> LoginWithEmailAndPassword(string email, string password);

        Task<String> SignUpWithEmailAndPassword(string email, string password);

        Task ResetPassword(string email);

        bool SignOut();

        bool IsSignIn();

        string GetUid();
    }
}
