using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BeenThereApp.Models;
using BeenThereApp.ViewModels;

namespace BeenThereApp.Views
{
    public partial class NewLocationPage : ContentPage
    {
        public Location Location { get; set; }

        public NewLocationPage()
        {
            InitializeComponent();
            BindingContext = new NewLocationsViewModel();
        }
    }
}