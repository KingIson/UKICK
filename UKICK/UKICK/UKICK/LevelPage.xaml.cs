using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UKICK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LevelPage : ContentPage
    {
        public LevelPage()
        {
            InitializeComponent();
        }
        private void Level1_Page(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new WorkingWithImages());
        }

        private void Level2_Page(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Level_2());
            
        }
        private void SettingPage (object sender, EventArgs e)
        {
           Navigation.PushModalAsync( new LevelPage()); 
        }
        private void Level4_Page(object sender, EventArgs e)
        {
            B3.IsEnabled=!B3.IsEnabled;
        }
        
    }
}