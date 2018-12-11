﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelpSGF.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HelpSGF
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();

            var navigationPage = new NavigationPage(MainPage)
            {
                BarBackgroundColor = Color.LightGreen,
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
