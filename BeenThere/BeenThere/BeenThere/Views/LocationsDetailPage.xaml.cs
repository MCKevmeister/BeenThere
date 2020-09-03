using System.ComponentModel;
using Xamarin.Forms;
using BeenThereApp.ViewModels;

namespace BeenThereApp.Views
{
    public partial class LocationDetailPage : ContentPage
    {
        public LocationDetailPage()
        {
            InitializeComponent();
            BindingContext = new LocationDetailViewModel();
        }
    }
}