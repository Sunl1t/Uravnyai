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

        private async void GoToForward5(object sender, EventArgs e)
        {
            zadanie6 page = new zadanie6();
            await Navigation.PushAsync(page);
            page.DisplayStack5();
        }

        protected internal void DisplayStack4()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }

        private async void GoToForvard5(object sender, EventArgs e)
        {
            zadanie5 page = new zadanie5();
            await Navigation.PushAsync(page);
            page.DisplayStack4();
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
        private void ButtonClick5(object sender, EventArgs e)
        {
            if (koef1.Text == "4" & (koef2.Text == "5") & koef3.Text == "2") //понадобится, когда буду прописывать пустые коэфы
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