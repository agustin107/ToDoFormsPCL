using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}