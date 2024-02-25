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
        protected internal void DisplayStack2()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        protected internal void DisplayStack3()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        protected internal void DisplayStack4()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        protected internal void DisplayStack5()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        protected internal void DisplayStack6()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        protected internal void DisplayStack7()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        protected internal void DisplayStack8()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        protected internal void DisplayStack9()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }




        //"GoToForward buttons
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
        
        private async void GoToForward2(object sender, EventArgs e)
        {
            zadanie3 page = new zadanie3();
            await Navigation.PushAsync(page);
            page.DisplayStack2();
        }

        private async void GoToForward3(object sender, EventArgs e)
        {
            zadanie4 page = new zadanie4();
            await Navigation.PushAsync(page);
            page.DisplayStack3();
        }

        private async void GoToForward4(object sender, EventArgs e)
        {
            zadanie5 page = new zadanie5();
            await Navigation.PushAsync(page);
            page.DisplayStack4();
        }

        private async void GoToForward5(object sender, EventArgs e)
        {
            zadanie6 page = new zadanie6();
            await Navigation.PushAsync(page);
            page.DisplayStack5();
        }

        private async void GoToForward6(object sender, EventArgs e)
        {
            zadanie7 page = new zadanie7();
            await Navigation.PushAsync(page);
            page.DisplayStack6();
        }

        private async void GoToForward7(object sender, EventArgs e)
        {
            zadanie8 page = new zadanie8();
            await Navigation.PushAsync(page);
            page.DisplayStack7();
        }
    }
}
