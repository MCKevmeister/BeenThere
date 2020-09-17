using System;
using System.Collections.Generic;
using System.Text;

namespace BeenThere.Models
{
    class BeenHere
    {
        public static List<BeenHere> Locations = new List<BeenHere>();
        
        public double Lat { get; set; }
        public double Long { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public BeenHere(double pLat, double pLong,  string pDescription, string pImagePath)
        {
            Lat = pLat;
            Long = pLong;
            Description = pDescription;
            ImagePath = pImagePath;

            BeenHere.Locations.Add(this);
        }
        
        public static string BeenHeres()
        {
            string result = "";
            foreach( BeenHere aBh in Locations)
            {
                result = aBh.Description + " Lat,Long = (" + aBh.Lat.ToString() + "," + aBh.Long.ToString() + ")\n" + result;
            }
            return result;
        }

    }
}
