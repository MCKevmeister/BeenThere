using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace BeenThere
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public class MapTest
        {
            public async Task NavigateToBuilding25()
            {
                var location = new Location(47.645160, -122.1306032);
                var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

                try
                {
                    await Map.OpenAsync(location, options);
                }
                catch (Exception ex)
                {
                    // No map application available to open
                }
            }
        }
    }
}
