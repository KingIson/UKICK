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
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();
            NationalStadium.Source = ImageSource.FromResource("UKICK.Images.NationalStadiumSingapore.jpg");
            SingaporeIndoorStadium.Source = ImageSource.FromResource("UKICK.Images.Singapore Indoor Stadium.jpg");
            JalanBesar.Source = ImageSource.FromResource("UKICK.Images.Jalan Besar Stadium.jpg");
            SeragoonStadium.Source = ImageSource.FromResource("UKICK.Images.Serangoon Stadium.jpg");
            ToaPayohStadium.Source = ImageSource.FromResource("UKICK.Images.Toapayoh-stadium.jpg");
        }

        


        //==========================================================================================================
        //Reference A3:
        //Purpose: Open the map using coordinates 
        //Date: Nov 13 2019
        //Source: Docs.Microsoft.com
        //Author: James Montemagno
        //url:https://docs.microsoft.com/en-us/xamarin/essentials/maps?content=xamarin%2Fxamarin-forms&tabs=android
        //===========================================================================================================
        private async void NationalStadium_Tapped(object sender, EventArgs e)
        {
            await Map.OpenAsync(1.3040, 103.8748, new MapLaunchOptions //launch the map according to the latitude and longitude
            {
                Name = "NationalStadium",
                NavigationMode = NavigationMode.None //navigate option to none 
            });
        }

        private async void SingaporeIndoorStadium_Tapped(object sender, EventArgs e)
        {
            await Map.OpenAsync(1.3006, 103.8744, new MapLaunchOptions
            {
                Name = "Singapore Indoor Stadium",
                NavigationMode = NavigationMode.None
            });
        }

        private async void JalanBesar_Tapped(object sender, EventArgs e)
        {
            await Map.OpenAsync(1.3100, 103.8603, new MapLaunchOptions
            {
                Name = "Jalan Besar Stadium",
                NavigationMode = NavigationMode.None
            });
        }

        private async void SeragoonStadium_Tapped(object sender, EventArgs e)
        {
            await Map.OpenAsync(1.3559, 103.8748, new MapLaunchOptions
            {
                Name = "Seragoon Stadium",
                NavigationMode = NavigationMode.None
            });
        }

        private async void ToaPayohStadium_Tapped(object sender, EventArgs e)
        {
            await Map.OpenAsync(1.3312, 103.8527, new MapLaunchOptions
            {
                Name = "ToaPayoh Stadium",
                NavigationMode = NavigationMode.None
            });
        }
    }
    //=============================================================================================================
    //End Reference A3
    //=============================================================================================================
}