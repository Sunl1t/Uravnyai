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
    public partial class zadanie7 : ContentPage
    {
        public zadanie7()
        {
            InitializeComponent();
            Title = "Задание 7";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack;
        }
        private async void GoToForward7(object sender, EventArgs e)
        {
            zadanie8 page = new zadanie8();
            await Navigation.PushAsync(page);
            page.DisplayStack7();
        }

        protected internal void DisplayStack6()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        async void GoToMenu(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void GoToBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Viper)navPage.CurrentPage).DisplayStack();
        }

        private void ButtonClick7(object sender, EventArgs e)
        {
            if ((koef1.Text == "2") & (koef2.Text == "9") & (koef3.Text == "6") & (koef4.Text == "6")) //понадобится, когда буду прописывать пустые коэфы
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