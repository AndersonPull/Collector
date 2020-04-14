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

            Imagens.FadeTo(0, 0, Easing.SinInOut);

            icons1.FadeTo(0, 0, Easing.SinInOut);
            icons2.FadeTo(0, 0, Easing.SinInOut);

            Timer timer = new Timer();

            timer.Interval = 5000;

            timer.Elapsed += OnTimedEvent1;

            timer.AutoReset = true;

            timer.Enabled = true;

            Timer timer1 = new Timer();

            timer1.Interval = 10000;

            timer1.Elapsed += OnTimedEvent2;

            timer1.AutoReset = true;

            timer1.Enabled = true;
        }

        private void OnTimedEvent1(object sender, ElapsedEventArgs e)
        {
            BarraProgresso2.ProgressTo(1, 5000, Easing.Linear);

            Text1.TranslateTo(-500, 0, 500, Easing.Linear);

            Text2.TranslateTo(320, 0, 500, Easing.Linear);

            Text3.TranslateTo(70, 0, 500, Easing.Linear);
            Text3.FadeTo(0, 600, Easing.SinInOut);


            Imagens.FadeTo(1, 500, Easing.SinInOut);

            Planet.TranslateTo(-80, 175, 500, Easing.Linear);
            Planet.ScaleTo(2.5, 500);
        }

        private void OnTimedEvent2(object sender, ElapsedEventArgs e)
        {
            BarraProgresso3.ProgressTo(1, 5000, Easing.Linear);

            Text2.TranslateTo(0, 0, 500, Easing.Linear);
            Text2.FadeTo(0, 400, Easing.SinInOut);

            Text4.TranslateTo(0, 250, 500, Easing.Linear);

            Planet.TranslateTo(0, 350, 400, Easing.Linear);
            Planet.FadeTo(0, 600, Easing.SinInOut);

            Imagens.TranslateTo(0, 560, 5000, Easing.Linear);
            Imagens.FadeTo(0, 300, Easing.SinInOut);

            Setas.TranslateTo(130, 0, 500,Easing.Linear);

            icons1.FadeTo(1, 700, Easing.SinInOut);
            icons1.ScaleTo(2, 1000);
            icons1.ScaleTo(1, 1000, Easing.SpringOut);

            icons2.FadeTo(1, 700, Easing.SinInOut);
            icons2.ScaleTo(2, 1000);
            icons2.ScaleTo(1, 1000, Easing.SpringOut);


        }
    }
}
