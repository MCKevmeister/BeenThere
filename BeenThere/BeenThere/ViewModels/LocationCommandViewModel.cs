using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using Xamarin.Forms;
using BeenThere.Models;

namespace BeenThere.ViewModels
{
    class LocationCommandViewModel : INotifyPropertyChanged
    {
        //Location location;
        double longitude = 0.0;
        double latitude = 0.0;
        string beentheres = "I've been everywhere!";

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand GetLocation { private set; get; }
        public string BeenTheres
        {
            set
            {
                beentheres = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BeenTheres"));
            }
            get { return beentheres; }

        }
        public double TheLongitude {
            set { longitude = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TheLongitude"));
            }
            get { return longitude; }
        }

        public double TheLatitude
        {
            set
            {
                latitude = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TheLatitude"));
            }
            get { return latitude; }
        }

        
        public LocationCommandViewModel()
        {
            GetLocation = new Command(() =>
            {
                BeenThere.Models.BeenHere aGoodSpot; 
                TheLongitude += 1.00 ;
                TheLatitude += 1.00;
                aGoodSpot = new Models.BeenHere(TheLongitude, TheLatitude, "Really it is ", "Path to image" + TheLongitude.ToString());
                BeenTheres = Models.BeenHere.BeenHeres();

                // You could add a DOMAIN ( MODEL ) class that is compsed into a list of BeenThereLocations.

                // DO NOT MOVE IN TO GEOLOCATON  ETC. GET THE THREE DISPLAYS WORKING , (USE FAKE DATA) 
                // ***********************************************************************************
                //        try
                //        {
                //            var location = await Geolocation.GetLastKnownLocationAsync();
                //            if (location == null)
                //            {
                //                location = await Geolocation.GetLocationAsync(new GeolocationRequest
                //                {
                //                    DesiredAccuracy = GeolocationAccuracy.Medium,
                //                    Timeout = TimeSpan.FromSeconds(15)
                //                });
                //            }
                //            if (location == null)
                //                Latitude.Text = "No GPS";
                //            else
                //            {
                //                Latitude.Text = $"{location.Latitude}";
                //                Longitude.Text = $"{location.Longitude}";
                //            }
                //        }
                //        catch (Exception ex)
                //        {
                //            Console.WriteLine(ex);
                //        }
            }
                
              );
        }


    }
}
