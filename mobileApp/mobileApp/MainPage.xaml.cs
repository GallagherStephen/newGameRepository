﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobileApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            image1();
        }

        //========================================================================
        private void image1()
        {
            var assembly = typeof(MainPage);
            string filename = "mobileApp.Images.mainPic.png";
            imageMain.Source = ImageSource.FromResource(filename, assembly);
        }


    //BELOW SENDING BUTTON FOR 2 PLAYERS TO (TWOPLAYER) PAGE WHERE ENTER NAME
    private void button1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new twoPlayer());
        }

        //BELOW PUT IN TO FIX PUSHASYNC PROBLEM ON EACH BUTTON
        private static void PushAsync(twoPlayer twoPlayer)
        {
            throw new NotImplementedException();
        }

        //=======================================================================

        //BELOW SENDING BUTTON FOR 3 PLAYERS TO (THREEPLAYER) PAGE WHERE ENTER NAME
        private void button2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThreePlayer());
        }

        //BELOW PUT IN TO FIX PUSHASYNC PROBLEM ON EACH BUTTON
        private static void PushAsync(ThreePlayer threePlayer)
        {
            throw new NotImplementedException();
        }

        private void Excercisesbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Excercises());
        }

        private void Information_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RulesAndInfo());
        }

        private void Oneplayer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new oneplayer());
        }

        //======================================================================
    }
}
