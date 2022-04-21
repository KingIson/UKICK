using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UKICK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]//get from http://xamaringuyshow.com/2018/09/26/xamarin-forms-welcomescreen-fading-splash-screen-tutorial-9/ 
    public partial class SplashPage : ContentPage
    {
        Image splashImage;

        //==========================================================================================================
        //Reference A1:
        //Purpose: Generate splash screen when opening the app
        //Date: Nov 15 2019
        //Source: Xamarin Guy Show
        //Author: Samir G.C
        //url:http://xamaringuyshow.com/2018/09/26/xamarin-forms-welcomescreen-fading-splash-screen-tutorial-9/
        //===========================================================================================================

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "ukick_logo.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage,
               AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#800080");
            this.Content = sub;
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 2000); //Time-consuming processes such as initialization
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);

            //=============================================================================================================
            //End Reference A1
            //=============================================================================================================
            Application.Current.MainPage = new NavigationPage(new Username());    //After loading  MainPage it gets Navigated to our new Page
        }
    }
}