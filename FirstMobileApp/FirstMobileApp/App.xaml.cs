﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FirstMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Arvaa luku -peli",
                            TextColor = Color.YellowGreen

                        },
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Sovellusversio 1.0",
                            TextColor = Color.Silver
                        },
                        new Entry
                        {
                            Keyboard = Keyboard.Numeric,
                            Text = ""
                        },
                        new Button
                        {
                            Text = "Arvaa"
                        }

                    }
                }
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
