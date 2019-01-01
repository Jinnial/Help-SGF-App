﻿using System;
using System.Collections.Generic;
using HelpSGF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace HelpSGF.Views
{
    public partial class SearchPage : ContentPage
    {
        void Handle_Clicked(Button sender, System.EventArgs e)
        {
            var value = sender.CommandParameter.ToString();
            //Navigation.PushAsync(new LocationsPage());
            Navigation.PushAsync(new CategoriesPage(value));

        }

        public SearchPage()
        {
            NavigationPage.SetBackButtonTitle(this, "");
            BindingContext = new MainPageViewModel();
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}
