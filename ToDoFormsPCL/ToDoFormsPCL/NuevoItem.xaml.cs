using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoFormsPCL.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoFormsPCL
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NuevoItem : ContentPage
	{
		public NuevoItem ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea {
                Nombre = nombreEntry.Text,
                Fecha = fechaLimiteDatePicker.Date,
                Hora = horaLimiteTimePicker.Time,
                Completada = false
            };

            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RutaDB))
            {
                conexion.CreateTable<Tarea>();

                var resultado = conexion.Insert(tarea);

                if (resultado > 0)
                    DisplayAlert("Exito", "El elemento se ha guardado", "Ok");
                else
                    DisplayAlert("Error", "Algo paso! Intenta de nuevo", "Ok");
            }
        }
    }
}