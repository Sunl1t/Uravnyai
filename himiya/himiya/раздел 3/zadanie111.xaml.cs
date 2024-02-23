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
	public partial class Zadanie111 : ContentPage
	{
		public Zadanie111 ()
		{
			InitializeComponent ();
            Title = "Задание 1";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack0;
        }
        private async void GoToForvard0(object sender, EventArgs e)
        {
            zadanie222 page = new zadanie222();
            await Navigation.PushAsync(page);
            page.DisplayStack1();
        }
        protected internal void DisplayStack0()
        {
            _ = (NavigationPage)App.Current.MainPage;

        }

        private async void GoToBack0(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((DeathAdder)navPage.CurrentPage).DisplayStack0();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((koef1.Text == "2") & (koef2.Text == "16") & (koef3.Text == "2") & (koef4.Text == "2") & (koef5.Text == "8") & (koef6.Text == "5"))
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