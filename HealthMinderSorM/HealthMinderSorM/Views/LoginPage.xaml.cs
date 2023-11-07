using HealthMinderSorM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthMinderSorM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private bool backButtonPressedOnce = false;
        private DateTime lastBackPressed = DateTime.MinValue;
        protected override bool OnBackButtonPressed()
        {
            if (backButtonPressedOnce)
            {
                if (DateTime.Now - lastBackPressed < TimeSpan.FromSeconds(2))
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
            backButtonPressedOnce = true;
            lastBackPressed = DateTime.Now;
            return true;
        }


        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        //Inicio de sesion sin sincronizacion de Firebas
        /*private async void Login_Btn_Clicked(object sender, EventArgs e)
        {
            String Usuario = TxtUser.Text;
            String Contraseña = TxtPass.Text;

            if (IsValidData(Usuario, Contraseña))
            {
                await DisplayAlert("Logrado", "Inicio Exitoso", "Ok");

                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Error", "Datos incorrectos", "Ok");
            }
        }

        private bool IsValidData(string usuario, string contraseña)
        {
            return usuario == "1" && contraseña == "1234";
        }

        private void PswdFrgt_Btn_Clicked(object sender, EventArgs e)
        {

        }*/
    }
}