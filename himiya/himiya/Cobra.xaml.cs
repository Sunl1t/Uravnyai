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
    public partial class Cobra : ContentPage
    {
        bool loaded = false;
        public Cobra()
        {
            InitializeComponent();
            NavigationPage Cobra = new NavigationPage();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (loaded == false)
            {
                DisplayStack();
                loaded = true;
            }
        }

        protected internal void DisplayStack()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        protected internal void DisplayStack1()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }

        private async void GoToForward(object sender, EventArgs e)
        {
            zadanie11 page = new zadanie11();
            await Navigation.PushAsync(page);
            page.DisplayStack();
        }
        private async void GoToForward1(object sender, EventArgs e)
        {
            zadanie22 page = new zadanie22();
            await Navigation.PushAsync(page);
            page.DisplayStack1();
        }
    }
}