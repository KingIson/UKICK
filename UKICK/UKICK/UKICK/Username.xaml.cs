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
    public partial class Username : ContentPage
    {
        public Username()
        {
            InitializeComponent();

            //====================================================================
            //Reference:A5
            //Purpose: to use detect shake to clear the text in the text box
            //Date: Nov 17 2019
            //Source: Docs.Microsoft.com
            //Author: James Montemagno
            //url:https://docs.microsoft.com/en-us/xamarin/essentials/detect-shake?context=xamarin/xamarin-forms
            //====================================================================

            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;
            Accelerometer.Start(SensorSpeed.Game);


            EnterNameImage.Source = ImageSource.FromResource("UKICK.Images.ukick_logo.png");
             
        }
        private void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            EnterName.Text = string.Empty;
        }
          
            //=============================================================================================================
            //End Reference A5
            //=============================================================================================================

        private async void Letplaybutton_Clicked(object sender, EventArgs e)
        {
            if(EnterName.Text != null)
            {
                App.name = EnterName.Text;
                await Navigation.PushAsync(new FirstPage());
            }
            else
            {
                await DisplayAlert("Input Error", "Name is not recognized", "OK");
            }

            //==========================================================================================================
            //Reference A6:
            //Purpose: To vibrate when goal is scored 
            //Date: Nov 18 2019
            //Source: Docs.Microsoft.com
            //Author: James Montemagno
            //url:https://docs.microsoft.com/en-us/xamarin/essentials/vibrate?context=xamarin%2Fxamarin-forms&tabs=android
            //===========================================================================================================
            

            try
            {
                Vibration.Vibrate(TimeSpan.FromMilliseconds(100));
            }
            catch
            {

            }
        }
          
            //=============================================================================================================
            //End Reference A6
            //=============================================================================================================

    }
}