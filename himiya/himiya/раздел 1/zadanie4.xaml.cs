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
    public partial class zadanie4 : ContentPage
    {
        public zadanie4()
        {
            InitializeComponent();
            Title = "Задание 4";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack;
        }

        private async void GoToForward4(object sender, EventArgs e)
        {
            zadanie5 page = new zadanie5();
            await Navigation.PushAsync(page);
            page.DisplayStack4();
        }

        protected internal void DisplayStack3()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
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
        private void ButtonClick4(object sender, EventArgs e)
        {
            if (koef1.Text == "4" & koef2.Text == "3" & koef3.Text == "2") //понадобится, когда буду прописывать пустые коэфы
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