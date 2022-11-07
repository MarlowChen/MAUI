using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiAppDemo.Models;

namespace MauiAppDemo.Service
{
    public interface IAuthService
    {
        Task<bool> LoginUserWithUserName(UserModel user);
        UserModel GetUser();
        Task<bool> IsLogin();
    }
}
