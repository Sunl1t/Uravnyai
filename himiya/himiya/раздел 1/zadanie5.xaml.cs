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
    public partial class zadanie5 : ContentPage
    {
        public zadanie5()
        {
            InitializeComponent();
            Title = "Задание 5";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack;
        }

        private async void GoToForvard(object sender, EventArgs e)
        {
            zadanie2 page = new zadanie2();
            await Navigation.PushAsync(page);
            page.DisplayStack1();
        }

        protected internal void DisplayStack()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }


        private async void GoToBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Viper)navPage.CurrentPage).DisplayStack();
        }

        private void ButtonClick5(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(koef1.Text) || (koef1.Text == "1")) & (koef2.Text == "2") & (string.IsNullOrEmpty(koef3.Text) || (koef3.Text == "1")) & (koef4.Text == "2")) //понадобится, когда буду прописывать пустые коэфы
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