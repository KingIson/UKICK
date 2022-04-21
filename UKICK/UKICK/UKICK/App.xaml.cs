using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UKICK
{
    public partial class App : Application
    {
        public static string name { get; set; }
        public static int balltype { get; set; }
        public static bool ball1 { get; set; }
        public static bool ball2 { get; set; }
        public static bool ball3 { get; set; }
        public static bool ball4 { get; set; }
        public static bool ball5 { get; set; }

        

        public App()
        {
            InitializeComponent();

            //MainPage = new FirstPage();
            MainPage = new NavigationPage(new SplashPage());
            App.ball1 = true;
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
