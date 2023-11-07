using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HealthMinderSorM.ViewModels
{
/*
    public class BaseShellViewModel : ContentPage
    {
        public BaseShellViewModel()
        {
            // Obtén una referencia al Shell de la página actual
            var shell = Shell.GetShell(this);

            // Verifica si se obtuvo una referencia válida al Shell
            if (shell != null)
            {
                // Configura elementos de menú comunes, rutas, encabezados, etc.
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Menú Principal"
                };

                var shellContent = new ShellContent()
                {
                    Content = new Label { Text = "Contenido de la página común" },
                    Title = "Página Común"
                };

                flyoutItem.Items.Add(shellContent);

                Shell.SetFlyoutItemIsVisible(this, true);
                Shell.SetFlyoutHeader(this, new Label { Text = "Encabezado del menú" });
                Shell.SetFlyoutFooter(this, new Label { Text = "Pie de menú" });
                Shell.SetFlyoutItemIsTabStop(this, true);

                Shell.SetItemIcon(flyoutItem, "HealthMinder_LogoLargo.png");
                Shell.SetItemTitle(flyoutItem, "Menú Principal");
                Shell.SetItemIsEnabled(flyoutItem, true);

                // Agrega el FlyoutItem al Shell
                shell.FlyoutItems.Add(flyoutItem);
            }
            else
            {
                // Maneja el caso en el que no se pueda obtener una referencia al Shell
            }
        }
    }*/

}
