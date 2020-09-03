using System;
using Xamarin.Forms;

namespace BeenThereApp.Models
{
    public class Account
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Image Photo { get; set; }
    }
}