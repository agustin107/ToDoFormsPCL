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
	public partial class ListaTareas : ContentPage
	{
		public ListaTareas ()
		{
			InitializeComponent ();

            var boton = new ToolbarItem
            {
                Text = "+"
            };

            boton.Clicked += Boton_Clicked;

            ToolbarItems.Add(boton);
		}

        private async void Boton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevoItem());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RutaDB))
            {
                List<Tarea> tareas = conexion.Table<Tarea>().ToList().Where(x => x.Completada == false).ToList();

                listaTareasListView.ItemsSource = tareas;
            }
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RutaDB))
            {
                var tarea = (sender as MenuItem).CommandParameter as Tarea;
                tarea.Completada = true;

                conexion.Update(tarea);

                List<Tarea> tareasFiltradas = conexion.Table<Tarea>().Where(x => x.Completada == false).ToList();
                listaTareasListView.ItemsSource = tareasFiltradas;
            }
        }
    }
}