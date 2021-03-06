﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoginXamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("PersistenciaUsuarioLogado"))
            {
                string usuario = Properties.ContainsKey("PersistenciaUsuarioLogado").ToString();

                MainPage = new MainPage();

            } else
            {
                MainPage = new Login();
            }            
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
