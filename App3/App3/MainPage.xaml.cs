﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            BackgroundImage = "mainmenu.jpg";
        }

        

        private async void Button_Clicked(object sender, EventArgs e)
        {
         
            await Navigation.PushAsync(new gamePage());
        }
    }
}
