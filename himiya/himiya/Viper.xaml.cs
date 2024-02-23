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
    public partial class Viper : ContentPage
    {
        bool loaded = false;
        public Viper()
        {
            InitializeComponent();
            NavigationPage Viper = new NavigationPage();
            IconImageSource = "Razdel_1_bely.png";
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
            /*stackLabel.Text = "";
            foreach (Page p in navPage.Navigation.NavigationStack)
            {
                stackLabel.Text += p.Title + "\n";
            }*/
        }
        protected internal void DisplayStack1()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }

        private async void GoToForward(object sender, EventArgs e)
        {
            zadanie1 page = new zadanie1();
            await Navigation.PushAsync(page);
            page.DisplayStack();
        }
        private async void GoToForward1(object sender, EventArgs e)
        {
            zadanie2 page = new zadanie2();
            await Navigation.PushAsync(page);
            page.DisplayStack1();
        }

    }
}
