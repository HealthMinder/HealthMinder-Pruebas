using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthMinderSorM.Views.Aplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeShellPageFlyout : ContentPage
    {
        public ListView ListView;

        public HomeShellPageFlyout()
        {
            InitializeComponent();

            BindingContext = new HomeShellPageFlyoutViewModel();
            ListView = MenuItemsListView;

            ListView.ItemSelected += OnMenuItemSelected;
        }

        private class HomeShellPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomeShellPageFlyoutMenuItem> MenuItems { get; set; }

            public HomeShellPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<HomeShellPageFlyoutMenuItem>(new[]
                {
                    new HomeShellPageFlyoutMenuItem("Inicio", typeof(HomePage)),
                    new HomeShellPageFlyoutMenuItem("Alarma Nueva", typeof(NewAlarmPage)),
                    new HomeShellPageFlyoutMenuItem("Consultar Alarmas", typeof(HistoryPage)),
                    new HomeShellPageFlyoutMenuItem ("Cerrar Sesion", typeof(LoginPage)),
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is HomeShellPageFlyoutMenuItem menuItem)
            {
                if (menuItem.Id == 0)
                {
                    await Navigation.PushAsync(new HomePage());
                }
                else if (menuItem.Id == 1)
                {
                    await Navigation.PushAsync(new NewAlarmPage());
                }
                else if (menuItem.Id == 2)
                {
                    await Navigation.PushAsync(new HistoryPage());
                }
                else if (menuItem.Id == 3)
                {
                    await Navigation.PushAsync(new LoginPage());
                }
                ListView.SelectedItem = null;
            }
        }

    }
}