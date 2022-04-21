using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading;

namespace UKICK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkingWithImages : ContentPage
    {
        Label lblDebug;

        double speedX, speedY;
        double imageX, imageY;
        int iDelay;
        AbsoluteLayout lytMain;
        Timer tmGameLoop;
       
     


        public WorkingWithImages()
        {
            InitializeComponent();
            lytMain = this.FindByName<AbsoluteLayout>("main_layout");
            lblDebug = this.FindByName<Label>("debug_label");

            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;  //initialize the plugin
            player.Load("AlarmRingtone.mp3"); //get the ringtone from android's asset
            player.Volume = 0.8;
            player.Play();

            image1.Source = "ClassicBall.png";

            if (App.balltype == 0)
            {
                image1.Source = "ClassicBall.png";
            }

            if (App.balltype == 1)
            {
                image1.Source = "purple soccer ball.png";
            }

            if (App.balltype == 2)
            {
                image1.Source = "purple 1 soccer ball.png";
            }

            if (App.balltype == 3)
            {
                image1.Source = "green soccer ball.png";
            }

            if (App.balltype == 4)
            {
                image1.Source = "orange soccer ball.png";
            }
            //else
            //{
            //    image1.Source = "ball_trans3.png";
            //}


            imageX = 10;
            imageY = 10;
            speedX = 10;
            speedY = 10;
            iDelay = 0;
            lytMain.Children.Add(image1, new Point(450,0));//450, 700

            //tmGameLoop = new Timer(timer_tick);
            //tmGameLoop.Change(0, 33);
          


        }
        private void timer_tick(object state)
        {
            iDelay--;
            if (iDelay == 1)
            {
                imageX = (int)(Width / 2);
                imageY = (int)(Height / 2);
                Device.BeginInvokeOnMainThread(MainThreadCode);
            }
            else if (iDelay <= 0)
            {
                imageX += speedX;
                imageY += speedY;
              
                if (imageX < 0)
                {
                   
                    imageX = 0;//stopping at the edge 
                    speedX = 10; // change the speed and changes the direction positive right direction 
                }
                if (imageX + image1.Width > Width)
                {

                    imageX = (int)(Width - image1.Width);
                    speedX = -speedX;


                }
                
                if (imageY < 0)
                {
                    imageY = 0; //stopping at the edge
                    speedY = -speedY; //change the speed 
                }
                if (imageY + image1.Height > Height)// 
                {
                    imageY = Height - image1.Height;
                    speedY = -speedY;
                }
                Device.BeginInvokeOnMainThread(MainThreadCode);
            }
        }
        void MainThreadCode()
        {
            image1.TranslateTo(imageX, imageY, 1,Easing.Linear);
            lblDebug.Text = DateTime.Now.ToString();
        }
    }
}