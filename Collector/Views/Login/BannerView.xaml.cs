using System;
using System.Timers;
using Xamarin.Forms;

namespace Collector.Views.Login
{
    public partial class BannerView : ContentPage
    {
        public BannerView()
        {
            InitializeComponent();

            BarraProgresso.ProgressTo(1, 5000, Easing.Linear);
            

            Timer timer = new Timer();

            timer.Interval = 5000;

            timer.Elapsed += OnTimedEvent;

            timer.AutoReset = true;

            timer.Enabled = true;

            Timer timer1 = new Timer();

            timer1.Interval = 10000;

            timer1.Elapsed += OnTimedEvent1;

            timer1.AutoReset = true;

            timer1.Enabled = true;
        }

        private void OnTimedEvent1(object sender, ElapsedEventArgs e)
        {
            BarraProgresso3.ProgressTo(1, 5000, Easing.Linear);

            Text2.TranslateTo(0, 0, 500, Easing.Linear);
            Text2.FadeTo(0, 400, Easing.SinInOut);

            Text4.TranslateTo(0, 250, 500, Easing.Linear);

            Planet.TranslateTo(0, 350, 500, Easing.Linear);
            Planet.FadeTo(0, 600, Easing.SinInOut);


        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            BarraProgresso2.ProgressTo(1, 5000, Easing.Linear);

            Text1.TranslateTo(-500, 0, 500, Easing.Linear);

            Text2.TranslateTo(320, 0, 500, Easing.Linear);

            Text3.TranslateTo(70, 0, 500, Easing.Linear);

            Text3.FadeTo(0, 600, Easing.SinInOut);

            Planet.TranslateTo(-80, 150, 500, Easing.Linear);


            Planet.ScaleTo(2.5, 500);
        }
    }
}
