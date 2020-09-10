using BeenThere.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeenThere
{
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void onSearchClicked(object sender, EventArgs e)
        {
            var searchPage = new Search();
            await Navigation.PushModalAsync(searchPage);
        }

        private async void onAccountClicked(object sender, EventArgs e)
        {
            var accountPage = new Account();
            await Navigation.PushModalAsync(accountPage);
        }

    }
}
