/*! \mainpage The IAuth Interface
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the IAuth Interface. It is the interface between the cross platform code and the native code.
 *
 */
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
