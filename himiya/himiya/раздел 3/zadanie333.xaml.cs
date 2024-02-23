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
    public partial class zadanie333 : ContentPage
    {
        public zadanie333 ()
        {
            InitializeComponent();
            Title = "Задание 3";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack1;
        }

        async void GoToMenu(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        protected internal void DisplayStack1()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;

        }

        private async void GoToBack1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((DeathAdder)navPage.CurrentPage).DisplayStack1();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((koef1.Text == "2") & (koef2.Text == "41") & (koef3.Text == "28") & (koef4.Text == "26"))
            {
                ErrorB.TextColor = Color.Green;
                ErrorB.Text = "Отлично, молодец!";
            }

            else
            {
                ErrorB.TextColor = Color.Red;
                ErrorB.Text = "Неверные коэффициенты!";

            }
        }
    }
}