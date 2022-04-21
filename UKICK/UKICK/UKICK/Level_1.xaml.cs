using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UKICK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Level_1 : ContentPage
    {
        Label timer;
        Timer gameloop;
        Image image1;
        public void timer_tick(object state)
        {
            image1.Source = ImageSource.FromResource("UKICK.Images.ball_trans3.png");
            Device.BeginInvokeOnMainThread(mainThreadCode);
            //====================================================================
            //var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;  //initialize the plugin
            //player.Load("AlarmRingtone.mp3"); //get the ringtone from android's asset
            //player.Volume = 0.8;
            //player.Play();
        }
        
        public Level_1()
        {
            InitializeComponent();
            field.Source = ImageSource.FromResource("UKICK.Images.SoccerField1.jpg");
            timer = this.FindByName<Label>("Time");
            gameloop = new Timer(timer_tick);
            gameloop.Change(0, 1000);

        }
        void mainThreadCode()
        {
            timer.Text = DateTime.Now.ToString();

        }
    }
}