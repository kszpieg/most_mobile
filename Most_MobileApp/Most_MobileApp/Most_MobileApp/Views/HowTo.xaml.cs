﻿using Most_MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Most_MobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HowTo : ContentPage
	{
		public HowTo ()
		{
			InitializeComponent();
            Init();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Init()
        {
            MostIcon.HeightRequest = Constants.LogoIconHeightInApp;
            LocalIcon.HeightRequest = Constants.LocalIconHeight;
            MostLocal.HeightRequest = Constants.LocalMapHeight;
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        void MenuOption(object sender, EventArgs args)
        {
            Picker MainMenu = (Picker)sender;

            App.chosenMenuOption = MainMenu.SelectedIndex;

            switch (App.chosenMenuOption)
            {
                case 0: //SDA MOST
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new HomePage());
                    }
                    else if (Device.RuntimePlatform == Device.iOS)
                    {
                        //soon
                    }
                    break;
                case 1: //Konstrukcja
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new Construction());
                    }
                    else if (Device.RuntimePlatform == Device.iOS)
                    {
                        //soon
                    }
                    break;
                case 2: //Duszpasterze
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new Priests());
                    }
                    else if (Device.RuntimePlatform == Device.iOS)
                    {
                        //soon
                    }
                    break;
                case 3: //Plan tygodnia
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new WeekPlan());
                    }
                    else if (Device.RuntimePlatform == Device.iOS)
                    {
                        //soon
                    }
                    break;
                case 4: //Jak trafić?
                    DisplayAlert("", "Jesteś na Jak trafić?", "OK");
                    break;
                case 5: //Kalendarz
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new MostCalendar());
                    }
                    else if (Device.RuntimePlatform == Device.iOS)
                    {
                        //soon
                    }
                    break;
            }
        }

        void BackProcedure(EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                Application.Current.MainPage = new NavigationPage(new StartPage());
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                //soon
            }
        }
    }
}