using System;
using Xamarin.Forms;

namespace BeenThereApp.Models
{
    public class AccountLocation
    {
        public string LocationID { get; set; }
        public string AccountID { get; set; }
        public DateTime DateVisited { get; set; }
        public string Comment { get; set; }
        public Image Photo { get; set; }
    }
}