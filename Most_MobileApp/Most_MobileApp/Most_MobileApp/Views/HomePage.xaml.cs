﻿using Most_MobileApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Most_MobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            Init();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Init()
        {
            MostIcon.HeightRequest = Constants.LogoIconHeightInApp;
            MostLogoContentGrid.HeightRequest = 100;
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
                    DisplayAlert("", "Jesteś na SDA MOST", "OK");
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
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new HowTo());
                    }
                    else if (Device.RuntimePlatform == Device.iOS)
                    {
                        //soon
                    }
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