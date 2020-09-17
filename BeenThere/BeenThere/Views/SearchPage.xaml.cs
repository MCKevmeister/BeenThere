using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeenThere.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();
        }

        //private async void onGetCoordinatesClicked(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var location = await Geolocation.GetLastKnownLocationAsync();
        //        if (location == null)
        //        {
        //            location = await Geolocation.GetLocationAsync(new GeolocationRequest
        //            {
        //                DesiredAccuracy = GeolocationAccuracy.Medium,
        //                Timeout = TimeSpan.FromSeconds(15)
        //            });
        //        }
        //        if (location == null)
        //            Latitude.Text = "No GPS";
        //        else
        //        {
        //            Latitude.Text = $"{location.Latitude}";
        //            Longitude.Text = $"{location.Longitude}";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}
    }
}