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
	public partial class zadanie2 : ContentPage
	{
		public zadanie2 ()
		{
            InitializeComponent();
            Title = "Задание 2";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack;
        }
        protected internal void DisplayStack1()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        private async void GoToBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Viper)navPage.CurrentPage).DisplayStack1();
        }
        /*async void GoToMenu(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }*/
        private void ButtonClick(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(koef2.Text) | koef2.Text == "1") & koef1.Text == "2" & (string.IsNullOrEmpty(koef3.Text) | koef3.Text == "1") & (string.IsNullOrEmpty(koef4.Text) | koef4.Text == "1"))
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