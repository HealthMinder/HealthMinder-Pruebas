using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace HealthMinderSorM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewAlarmPage : ContentPage
    {
        private List<MedicationRecord> medicationRecords = new List<MedicationRecord>();
        public NewAlarmPage()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(medicationNameEntry.Text) ||
        string.IsNullOrWhiteSpace(dosageEntry.Text) ||
        timePicker.Time == TimeSpan.Zero)
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            }
            else
            {
                int dosage = Convert.ToInt32(dosageEntry.Text);
                TimeSpan dosageTime = timePicker.Time;

                // Crea un nuevo objeto de registro de medicamento
                var newRecord = new MedicationRecord
                {
                    MedicationName = medicationNameEntry.Text,
                    DosageQuantity = dosage,
                    DosageTime = dosageTime
                };

                // Agrega la nueva alarma a la lista
                medicationRecords.Add(newRecord);

                // Mensaje de guardado y limpieza de las líneas
                DisplayAlert("Éxito", "Registro guardado correctamente.", "OK");
                medicationNameEntry.Text = string.Empty;
                dosageEntry.Text = string.Empty;
                timePicker.Time = TimeSpan.Zero;
            }

        }

        public class MedicationRecord
        {
            public string MedicationName { get; set; }
            public int DosageQuantity { get; set; }
            public TimeSpan DosageTime { get; set; }
        }
    }
}