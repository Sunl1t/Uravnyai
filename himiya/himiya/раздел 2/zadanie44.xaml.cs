﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace himiya
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class zadanie44 : ContentPage
    {
        public zadanie44()
        {
            InitializeComponent();
            Title = "Задание 4";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack1;
        }
        async void GoToMenu(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        protected internal void DisplayStack3()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;

        }
        private async void GoToForward3(object sender, EventArgs e)
        {
            zadanie55 page = new zadanie55();
            await Navigation.PushAsync(page);
            page.DisplayStack4();
        }
        private async void GoToBack1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Cobra)navPage.CurrentPage).DisplayStack();
        }

        private void ButtonClick1(object sender, EventArgs e)
        {
            if ((koef1.Text == "3") & (koef2.Text == "2") & (string.IsNullOrEmpty(koef3.Text) | (koef3.Text == "1")) & (koef4.Text == "3") & (koef5.Text == "2") & (koef6.Text == "2"))
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