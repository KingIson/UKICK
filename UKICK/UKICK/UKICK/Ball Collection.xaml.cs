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
    public partial class Ball_Collection : ContentPage
    {
       
        public Ball_Collection()
        {
            InitializeComponent();
            ClassicBall.Source = ImageSource.FromResource("UKICK.Images.ClassicBall.png");
            PurpleBallStyle1.Source = ImageSource.FromResource("UKICK.Images.purple soccer ball.png");
            PurpleBallStyle2.Source = ImageSource.FromResource("UKICK.Images.purple 1 soccer ball.png");
            GreenClassicBall.Source = ImageSource.FromResource("UKICK.Images.green soccer ball.png");
            OrangeClassicBall.Source = ImageSource.FromResource("UKICK.Images.orange soccer ball.png");
            //RedClassicBall.Source = ImageSource.FromResource("UKICK.Images.Red Nike Ball.jpg");
            //BrazilianBall.Source = ImageSource.FromResource("UKICK.Images.BrazilianBall.png");
            //Orangeball.Source = ImageSource.FromResource("UKICK.Images.Orange ball.jpg");

            

           if(App.ball1 == true)//To make sure that the ball is selected in ball collection
            {
                Classic.Text = "SELECTED";
            }
           else
            {
                Classic.Text = "SELECT";
            }

            if (App.ball2 == true)
            {
                PurpleStyle1.Text = "SELECTED";
            }
            else
            {
                PurpleStyle1.Text = "SELECT";
            }

            if (App.ball3 == true)
            {
                PurpleStyle2.Text = "SELECTED";
            }
            else
            {
                PurpleStyle2.Text = "SELECT";
            }

            if (App.ball4 == true)
            {
                GreenBall.Text = "SELECTED";
            }
            else
            {
                GreenBall.Text = "SELECT";
            }

            if (App.ball5 == true)
            {
                OrangeBall.Text = "SELECTED";
            }
            else
            {
                OrangeBall.Text = "SELECT";
            }

        }
        private void btn_ClassicBall(object sender, EventArgs e)
        {

            //(sender as Button).Text = "SELECT";
            Classic.Text = "SELECTED";
            PurpleStyle1.Text = "SELECT";
            PurpleStyle2.Text = "SELECT";
            GreenBall.Text = "SELECT";
            OrangeBall.Text = "SELECT";
            App.balltype = 0;

            App.ball1 = true;
            App.ball2 = false;
            App.ball3 = false;
            App.ball4 = false;
            App.ball5 = false;
        }


        private void btnPurpleStyle1Ball(object sender, EventArgs e)
        {
            //(sender as Button).Text = "SELECT";           
            Classic.Text = "SELECT";
            PurpleStyle1.Text = "SELECTED";
            PurpleStyle2.Text = "SELECT";
            GreenBall.Text = "SELECT";
            OrangeBall.Text = "SELECT";
            App.balltype = 1;

            App.ball1 = false;
            App.ball2 = true;
            App.ball3 = false;
            App.ball4 = false;
            App.ball5 = false;
        }

        //private void btnPurpleBallPressed(object sender, EventArgs e)
        //{
        //    (sender as Button).Text = "SELECTED";
        //}
        private void btnPurpleStyle2Ball(object sender, EventArgs e)
        {
            //(sender as Button).Text = "SELECT";
            Classic.Text = "SELECT";
            PurpleStyle1.Text = "SELECT";
            PurpleStyle2.Text = "SELECTED";
            GreenBall.Text = "SELECT";
            OrangeBall.Text = "SELECT";
            App.balltype = 2;

            App.ball1 = false;
            App.ball2 = false;
            App.ball3 = true;
            App.ball4 = false;
            App.ball5 = false;
        }

        //private void btnBrazilianBallClicked(object sender, EventArgs e)
        //{
        //    (sender as Button).Text = "SELECTED";
        //}

        private void btnGreenBall(object sender, EventArgs e)
        {
            Classic.Text = "SELECT";
            PurpleStyle1.Text = "SELECT";
            PurpleStyle2.Text = "SELECT";
            GreenBall.Text = "SELECTED";
            OrangeBall.Text = "SELECT";
            App.balltype = 3;

            App.ball1 = false;
            App.ball2 = false;
            App.ball3 = false;
            App.ball4 = true;
            App.ball5 = false;
        }

        private void btnOrangeBall(object sender, EventArgs e)
        {
            Classic.Text = "SELECT";
            PurpleStyle1.Text = "SELECT";
            PurpleStyle2.Text = "SELECT";
            GreenBall.Text = "SELECT";
            OrangeBall.Text = "SELECTED";
            App.balltype = 4;

            App.ball1 = false;
            App.ball2 = false;
            App.ball3 = false;
            App.ball4 = false;
            App.ball5 = true;
        }

        //private void btnOrangeBallClicked(object sender, EventArgs e)
        //{
        //    (sender as Button).Text = "SELECTED";
        //}
    }
}