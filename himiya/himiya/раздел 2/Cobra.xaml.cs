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



        private async void GoToPage(object sender, EventArgs e)
        {
            zadanie11 page = new zadanie11();
            await Navigation.PushAsync(page);
            page.DisplayStack();
        }
        private async void GoToPage1(object sender, EventArgs e)
        {
            zadanie22 page = new zadanie22();
            await Navigation.PushAsync(page);
            page.DisplayStack1();
        }
        private async void GoToPage2(object sender, EventArgs e)
        {
            zadanie33 page = new zadanie33();
            await Navigation.PushAsync(page);
            page.DisplayStack2();
        }
        private async void GoToPage3(object sender, EventArgs e)
        {
            zadanie44 page = new zadanie44();
            await Navigation.PushAsync(page);
            page.DisplayStack3();
        }
        private async void GoToPage4(object sender, EventArgs e)
        {
            zadanie55 page = new zadanie55();
            await Navigation.PushAsync(page);
            page.DisplayStack4();
        }
        private async void GoToPage5(object sender, EventArgs e)
        {
            zadanie66 page = new zadanie66();
            await Navigation.PushAsync(page);
            page.DisplayStack5();
        }
        private async void GoToPage6(object sender, EventArgs e)
        {
            zadanie77 page = new zadanie77();
            await Navigation.PushAsync(page);
            page.DisplayStack6();
        }
        private async void GoToPage7(object sender, EventArgs e)
        {
            zadanie88 page = new zadanie88();
            await Navigation.PushAsync(page);
            page.DisplayStack7();
        }
    }
}