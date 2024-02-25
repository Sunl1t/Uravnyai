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
    public partial class zadanie55 : ContentPage
    {
        public zadanie55()
        {
            InitializeComponent();
            Title = "Задание 5";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack1;
        }
        async void GoToMenu(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        protected internal void DisplayStack4()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;

        }

        private async void GoToBack1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Cobra)navPage.CurrentPage).DisplayStack();
        }
        private async void GoToForward4(object sender, EventArgs e)
        {
            zadanie66 page = new zadanie66();
            await Navigation.PushAsync(page);
            page.DisplayStack5();
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