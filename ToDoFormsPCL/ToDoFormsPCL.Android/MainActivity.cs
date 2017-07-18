using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace ToDoFormsPCL.Droid
{
    [Activity(Label = "ToDoFormsPCL", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            string nombreArchivoDB = "db.sqlite";
            string directorioDB = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string rutaDB = Path.Combine(directorioDB, nombreArchivoDB);

            LoadApplication(new App(rutaDB));
        }
    }
}

