using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiAppDemo.Models;

namespace MauiAppDemo.Service
{
    public class AuthService : IAuthService
    {
        private UserModel _user;
        public bool isLogin = false;
        private readonly static String defaultUserName = "admin";
        private readonly static String defaultPassword = "1234";

        public UserModel GetUser()
        {
            return _user;
        }
        public async Task<bool> IsLogin()
        {
            await Task.Delay(10);
            return isLogin;
        }

        public async Task<bool> LoginUserWithUserName(UserModel user)
        {
            try
            {
                bool confirmUserName = user.username.ToLower().Equals(defaultUserName);
                bool confirmPassword = user.password.Equals(defaultPassword);
                if(!confirmUserName || !confirmPassword)
                {
                    throw new Exception("Error check user.");
                }
                _user = new UserModel
                {
                    username = defaultUserName,
                    password = "",
                };
        
                isLogin = true;
                return true;
            }
            catch
            {
                isLogin = false;
                return false;
            }
        }
    }
}
