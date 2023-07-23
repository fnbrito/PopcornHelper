using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PopcornHelper.Views;
using Realms.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopcornHelper.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {

        [ObservableProperty]
        string emailText;

        [ObservableProperty]
        string passwordText;

        public LoginPageViewModel()
        {
            EmailText = "filipe@test.com";
            PasswordText = "testpw";
        }

        [RelayCommand]
        async Task Register()
        {
            try
            {
                await App.RealmApp.EmailPasswordAuth.RegisterUserAsync(EmailText, PasswordText);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error creating account!", "Error: " + ex.Message, "OK");
            }
        }

        [RelayCommand]
        public async Task Login()
        {
            try
            {
                var user = await App.RealmApp.LogInAsync(Credentials.EmailPassword(EmailText, PasswordText));

                if (user is not null)
                {
                    await Shell.Current.GoToAsync("//Home");
                    EmailText = string.Empty;
                    PasswordText = string.Empty;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error creating account!", "Error: " + ex.Message, "OK");
            }
        }

    }
}
