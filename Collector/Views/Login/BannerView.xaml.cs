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

            Imagens.FadeTo(0, 0, Easing.SinInOut);
            icons1.FadeTo(0, 0, Easing.SinInOut);
            icons2.FadeTo(0, 0, Easing.SinInOut);

            BarraProgresso.ProgressTo(1, 6000, Easing.Linear);

            Timer timer = new Timer();

            timer.Interval = 6000;

            timer.Elapsed += OnTimedEvent1;

            timer.AutoReset = false;

            timer.Enabled = true;
        }

        private void OnTimedEvent1(object sender, ElapsedEventArgs e)
        {
            BarraProgresso2.ProgressTo(1, 5000, Easing.Linear);

            Text1.TranslateTo(-500, 0, 500, Easing.Linear);

            Text2.TranslateTo(370, 0, 500, Easing.Linear);

            Text3.TranslateTo(70, 0, 500, Easing.Linear);
            Text3.FadeTo(0, 600, Easing.SinInOut);


            Imagens.FadeTo(1, 500, Easing.SinInOut);

            Planet.TranslateTo(-80, 175, 500, Easing.Linear);
            Planet.ScaleTo(2.5, 500);

            Timer timer = new Timer();

            timer.Interval = 5000;

            timer.Elapsed += OnTimedEvent2;

            timer.AutoReset = false;

            timer.Enabled = true;
        }

        private void OnTimedEvent2(object sender, ElapsedEventArgs e)
        {
            BarraProgresso3.ProgressTo(1, 5000, Easing.Linear);

            Text2.TranslateTo(0, 0, 500, Easing.Linear);
            Text2.FadeTo(0, 400, Easing.SinInOut);

            Text4.TranslateTo(0, 290, 500, Easing.Linear);

            Planet.TranslateTo(0, 350, 400, Easing.Linear);
            Planet.FadeTo(0, 600, Easing.SinInOut);

            Imagens.FadeTo(0, 300);
            Imagens.TranslateTo(0, 560, 2000, Easing.Linear);
            Imagens.ScaleTo(0, 500, Easing.Linear);

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
