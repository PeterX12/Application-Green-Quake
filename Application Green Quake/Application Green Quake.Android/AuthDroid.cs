/*! \class The AuthDroid Native Android Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the AuthDroid Native Android Class. This is implements native functions to check if a user is signed in, o try and log in, to try and
 * sign up to get their uid and to get a password rest email.
 *
 */
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Application_Green_Quake.Droid;
using Firebase.Auth;

[assembly: Dependency(typeof(AuthDroid))]
namespace Application_Green_Quake.Droid
{
    public class AuthDroid : IAuth
    {
        /** This function checks if a user is signed in.
        */
        public bool IsSignIn()
        {
            var user = FirebaseAuth.Instance.CurrentUser;
            return user != null;
          
        }
        /** This function logs a user into the application
        */
        public async Task<string> LoginWithEmailAndPassword(string email, string password)
        {
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = user.User.Uid;
                return token;
            }
            catch (FirebaseAuthInvalidUserException e)
            {
                e.PrintStackTrace();
                return string.Empty;
            }
            catch (FirebaseAuthInvalidCredentialsException e)
            {
                e.PrintStackTrace();
                return string.Empty;
            }
        }
        /** This function signs a user out of the application.
        */
        public bool SignOut()
        {
            try
            {
                FirebaseAuth.Instance.SignOut();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        /** This function allows a user to sign up into the app.
        */
        public async Task<string> SignUpWithEmailAndPassword(string email, string password)
        {
            try
            {
                var newUser = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
                var token = newUser.User.Uid;
                return token;
            }
            catch (FirebaseAuthUserCollisionException e)
            {
                e.PrintStackTrace();
                return "duplicate";
            }
            catch (FirebaseAuthInvalidUserException e)
            {
                e.PrintStackTrace();
                return string.Empty;
            }
            catch (FirebaseAuthInvalidCredentialsException e)
            {
                e.PrintStackTrace();
                return string.Empty;
            }
        }
        /** This function gets the currently signed in users UID.
        */
        public string GetUid()
        {
            var user = FirebaseAuth.Instance.CurrentUser;
            if (user != null)
            {
                try
                {
                    var uid = user.Uid;
                    return uid;
                }
                catch (FirebaseAuthInvalidUserException e)
                {
                    e.PrintStackTrace();
                    return string.Empty;
                }
                catch (FirebaseAuthInvalidCredentialsException e)
                {
                    e.PrintStackTrace();
                    return string.Empty;
                }
            }
            else
            {
                return "";
            }
        }
        /** This function sends the password reset email.
        */
        public async Task ResetPassword(string email)
        {
            await FirebaseAuth.Instance.SendPasswordResetEmailAsync(email);
        }
    }
}