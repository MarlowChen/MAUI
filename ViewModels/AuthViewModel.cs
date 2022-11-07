using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppDemo.Models;
using MauiAppDemo.Service;

namespace MauiAppDemo.ViewModels
{
    [QueryProperty(nameof(User), "User")]
    public partial class AuthViewModel : ObservableObject
    {
        [ObservableProperty]
        private UserModel _user = new UserModel();
        private readonly IAuthService _authService;
        public AuthViewModel(IAuthService authService)
        {
            _authService = authService;
        }

        [RelayCommand]
        public async void LoginUserWithUserName()
        {
            var result = await _authService.LoginUserWithUserName(new Models.UserModel
            {
                username = User.username,
                password = User.password,
            });
            if (result)
            {
                await Shell.Current.DisplayAlert("Status: Login Success", "Login Success", "Ok");
                await AppShell.Current.GoToAsync(nameof(MainPage));

            }
            else
            {
                await Shell.Current.DisplayAlert("Status: Login Failed", "Login failed", "Ok");
            }
        }

    }
}
