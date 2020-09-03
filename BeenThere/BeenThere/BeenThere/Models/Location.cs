using System;
using Xamarin.Forms;

namespace BeenThereApp.Models
{
    public class Location
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Creator { get; set; }
        public DateTime DateCreated { get; set; }
        public Image Photo { get; set; }
        public void createLocation(String pName, Double pLatitude, Double pLongitude, String pCreator, DateTime pDayCreated, Image pPhoto)
        {
            //TODO
            return;
        }
        public void editLocation(Location pLocation)
        {
            //TODO
            return;
        }
        public void deleteLocation(Location pLocation)
        {
            //TODO
            return;
        }
    }
}