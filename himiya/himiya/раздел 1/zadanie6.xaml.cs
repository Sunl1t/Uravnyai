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
    public partial class zadanie6 : ContentPage
    {
        public zadanie6()
        {
            InitializeComponent();
            Title = "Задание 6";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack;
        }

        protected internal void DisplayStack5()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }

        private async void GoToForward6(object sender, EventArgs e)
        {
            zadanie7 page = new zadanie7();
            await Navigation.PushAsync(page);
            page.DisplayStack6();
        }
        private async void GoToBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Viper)navPage.CurrentPage).DisplayStack();
        }
        async void GoToMenu(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        private void ButtonClick6(object sender, EventArgs e)
        {
            if ((koef1.Text == "4") & (string.IsNullOrEmpty(koef2.Text) || (koef2.Text == "1")) & (koef3.Text == "2")) 
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