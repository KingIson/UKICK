using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace UKICK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            UkickLogo.Source = ImageSource.FromResource("UKICK.Images.ukick_logo.png");
            Name.Text = " Welcome " + App.name;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new WorkingWithImages());

            //====================================================================
            //Reference:A4
            //Purpose: to play the click sound in button using Plugin.SimpleAudioPlayer
            //Date: Nov 17 2019
            //Source: github
            //Author: Adrian Stevens
            //url:https://github.com/adrianstevens/Xamarin-Plugins/tree/master/SimpleAudioPlayer
            //====================================================================

            var sound = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            sound.Load("AlarmRingtone.mp3"); //fetch the rightone from the source
            sound.Volume = 0.8;
            sound.Play();

            //=====================================================================
            //End Reference A4
            //=====================================================================
           

        }
        //async button_Clicked 
        private void SettingPage(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LevelPage());
        }

        private void BallCollection(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Ball_Collection());
        }

        private void Stadium(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MapsPage());
        }
    }
}