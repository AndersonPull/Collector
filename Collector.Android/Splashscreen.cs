using Android.App;
using Android.Content.PM;
using Android.Support.V7.App;

namespace Collector.Droid
{
    [Activity(Label = "Collector", Icon = "@mipmap/icon", Theme = "@style/splashscreen", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Locked)]
    class splashscreen : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
        }
    }
}