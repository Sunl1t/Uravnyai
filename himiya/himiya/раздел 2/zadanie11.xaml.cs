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
    public partial class zadanie11 : ContentPage
    {
        public zadanie11()
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
        private async void GoToForward(object sender, EventArgs e)
        {
            zadanie22 page = new zadanie22();
            await Navigation.PushAsync(page);
            page.DisplayStack1();
        }
        private async void GoToBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Cobra)navPage.CurrentPage).DisplayStack();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((koef1.Text == "5") & (koef2.Text == "2") & (koef3.Text == "3") & (koef4.Text == "5") & (koef5.Text == "2") & (string.IsNullOrEmpty(koef6.Text) | koef6.Text == "1") & (koef7.Text == "3")) 
            {
                ErrorB.TextColor = Color.Green;
                ErrorB.Text = "Отлично, молодец!";
            }

            else
            {
                ErrorB.TextColor = Color.Red;
                ErrorB.Text = "Неверные коэффициенты!";

                /*await DisplayAlert("Данные", "Ответ получен", "Отправить");*/ //вывод уведомления на экран если нужно будет добавить оповещение - задать asinc (in func)
            }
        }
    }
}