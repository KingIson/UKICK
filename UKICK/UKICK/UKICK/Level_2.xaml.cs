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
    public partial class Level_2 : ContentPage
    {
        public Level_2()
        {
            InitializeComponent();
        }
        private void Setting_Page(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SettingPage());
        }

    }
}