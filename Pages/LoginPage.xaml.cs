using MauiAppDemo.ViewModels;

namespace MauiAppDemo.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage(AuthViewModel vm)
	{
		InitializeComponent();
        this.BindingContext = vm;
    }


}