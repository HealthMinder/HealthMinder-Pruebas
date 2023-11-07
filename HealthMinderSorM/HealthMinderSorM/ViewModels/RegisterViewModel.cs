using Firebase.Auth;
using HealthMinderSorM.Conexion;
using HealthMinderSorM.Models;
using HealthMinderSorM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthMinderSorM.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        #region
        private string email;
        private string password;

        public string TxtRUser
        {
            get { return email; }
            set { SetValue(ref email, value); }
        }

        public string TxtRPass
        {
            get { return password; }
            set { SetValue(ref password, value); }
        }

        public Command RegisterCommand { get; }

        public RegisterViewModel(INavigation navigate)
        {
            Navigation = navigate;
            RegisterCommand = new Command(async () => await RegisterUser());
        }

        private async Task RegisterUser()
        {
            try
            {
                

                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(DBConn.WepApiAuthentication));
                var authResult = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                string userToken = authResult.FirebaseToken;

                

                await App.Current.MainPage.DisplayAlert("Registro Exitoso", "Tu cuenta ha sido registrada con éxito.", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
        #endregion


    }
}
