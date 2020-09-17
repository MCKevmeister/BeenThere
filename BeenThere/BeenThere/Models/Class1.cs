using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace BeenThere.Models
{
    class Class1
    {
        public string myLat;
        public string myLong;
        public async void getLocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(15)
                    });
                }
                if (location == null)
                    myLat = "No GPS";
                else
                {
                    myLat = $"{location.Latitude}";
                    myLong = $"{location.Longitude}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
    }
}
