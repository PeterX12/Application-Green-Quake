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
        public bool IsSignIn()
        {
            var user = FirebaseAuth.Instance.CurrentUser;
            if (user == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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

        public async Task<string> SignUpWithEmailAndPassword(string email, string password)
        {
            try
            {
                var newUser = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
                var token = newUser.User.Uid;
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
    }
}