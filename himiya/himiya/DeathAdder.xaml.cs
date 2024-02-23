using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace himiya
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeathAdder : ContentPage
    {
        bool loaded = false;
        public DeathAdder()
        {
            InitializeComponent();
            NavigationPage DeathAdder = new NavigationPage();
            IconImageSource = "Razdel_3_bely.png";

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (loaded == false)
            {
                DisplayStack0();
                loaded = true;
            }
        }
        protected internal void DisplayStack0()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        protected internal void DisplayStack1()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }

        private async void GoToForward0(object sender, EventArgs e)
        {
            Zadanie111 page = new Zadanie111();
            await Navigation.PushAsync(page);
            page.DisplayStack0();
        }
        private async void GoToForward1(object sender, EventArgs e)
        {
            zadanie222 page = new zadanie222();
            await Navigation.PushAsync(page);
            page.DisplayStack1();
        }
    }

}