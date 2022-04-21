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
    public partial class Enter_Name : ContentPage
    {
        public Enter_Name()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = Name.Text;

            NameLabel.Text = " Welcome " + text;
        }
    }
}