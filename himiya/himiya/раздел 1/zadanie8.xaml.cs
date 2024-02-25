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
    public partial class zadanie8 : ContentPage
    {
        public zadanie8()
        {
            InitializeComponent();
            Title = "Задание 8";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack8;
        }

/*        private async void GoToForward8(object sender, EventArgs e)
        {
            zadanie8 page = new zadanie8();
            await Navigation.PushAsync(page);
            page.DisplayStack7();
        }*/

        protected internal void DisplayStack7()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        async void GoToMenu(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void GoToBack8(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Viper)navPage.CurrentPage).DisplayStack();
        }

        /*async void GoToMenu(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }*/
        private void ButtonClick8(object sender, EventArgs e)
        {
            if ((koef1.Text == "2") & (koef2.Text == "3") & (koef3.Text == "2") & (koef4.Text == "2")) 
            {
                ErrorA.TextColor = Color.Green;
                ErrorA.Text = "Отлично, молодец!";
            }

            else
            {
                ErrorA.TextColor = Color.Red;
                ErrorA.Text = "Неверные коэффициенты!";

                /*await DisplayAlert("Данные", "Ответ получен", "Отправить");*/ //вывод уведомления на экран
            }
        }
    }
}