﻿using Application_Green_Quake.iOS;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Firebase.Auth;
using Foundation;

[assembly: Dependency(typeof(AuthiOS))]
namespace Application_Green_Quake.iOS
{
    public class AuthiOS : IAuth
    {
        public bool IsSignIn()
        {
            var user = Auth.DefaultInstance.CurrentUser;
            return user != null;
        }

        public async Task<string> LoginWithEmailAndPassword(string email, string password)
        {
            try
            {
                var user = await Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
                return await user.User.GetIdTokenAsync();
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }

        public bool SignOut()
        {
            try
            {
                _ = Auth.DefaultInstance.SignOut(out NSError error);
                return error == null;
            }catch (Exception e)
            {
                return false;
            }
            
        }

        public async Task<string> SignUpWithEmailAndPassword(string email, string password)
        {
            try
            {
                var newUser = await Auth.DefaultInstance.CreateUserAsync(email, password);
                return await newUser.User.GetIdTokenAsync();
            }catch(Exception e)
            {
                return string.Empty;
            }
        }    
    }
}