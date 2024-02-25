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
    public partial class zadanie1 : ContentPage

    {
        /*bool loaded = false;
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (loaded == false)
            {
                DisplayStack();
                loaded = true;
            }
        }*/

        public zadanie1()
        {
            InitializeComponent();
            Title = "Задание 1";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack;
        }


        protected internal void DisplayStack()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        }
        private async void GoToForward1(object sender, EventArgs e)
        {
            zadanie2 page = new zadanie2();
            await Navigation.PushAsync(page);
            page.DisplayStack1();
        }

        private async void GoToBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Viper)navPage.CurrentPage).DisplayStack();
        }

        private void ButtonClick(object sender, EventArgs e)
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
