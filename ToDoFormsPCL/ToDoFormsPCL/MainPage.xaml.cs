using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoFormsPCL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(usuarioEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
            {
                resultadoLabel.Text = "Debe ingresar un usuario y password";
            }
            else
            {
                resultadoLabel.Text = "Inicio de sesion exitoso";
                await Navigation.PushAsync(new ListaTareas());
            }
        }
    }
}
