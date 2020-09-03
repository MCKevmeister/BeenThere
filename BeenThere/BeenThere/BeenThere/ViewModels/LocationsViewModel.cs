using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using BeenThereApp.Models;
using BeenThereApp.Views;

namespace BeenThereApp.ViewModels
{
    public class LocationsViewModel : BaseViewModel
    {
        private Location _selectedLocation;

        public ObservableCollection<Location> locations { get; }
        public Command LoadLocationCommand { get; }
        public Command AddLocationCommand { get; }
        public Command<Location> LocationTapped { get; }

        public LocationsViewModel()
        {
            Title = "Browse";
            Location = new ObservableCollection<Location>();
            LoadLocationCommand = new Command(async () => await ExecuteLoadLocationsCommand());

            LocationTapped = new Command<Location>(OnLocationSelected);

            AddLocationCommand = new Command(OnAddLocation);
        }

        async Task ExecuteLoadLocationCommand()
        {
            IsBusy = true;

            try
            {
                Locations.Clear();
                var locations = await DataStore.GetLocationsAsync(true);
                foreach (var location in locations)
                {
                    locations.Add(location);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedLocation = null;
        }

        public Location SelectedLocation
        {
            get => _selectedLocation;
            set
            {
                SetProperty(ref _selectedLocation, value);
                OnLocationSelected(value);
            }
        }

        private async void OnAddLocation(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewLocationPage));
        }

        async void OnLocationSelected(Location location)
        {
            if (location == null)
                return;

            // This will push the LocationDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(LocationDetailPage)}?{nameof(LocationDetailViewModel.LocationId)}={location.Id}");
        }
    }
}