﻿using System;
using Triangulo_RLG;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrianguloRLG2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
