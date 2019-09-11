using System.Threading.Tasks;
using Collector.Services.Navigation;
using Collector.ViewModels.ViewModelLocator;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;

namespace Collector
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FlowListView.Init();
            InitNavigation();
        }

        public Task InitNavigation()
        {
            var navigationService = Locator.Instance.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override void OnStart()
        {
            AppCenter.Start("98dc8fdf-10c1-4139-9758-0bbd010791e4", typeof(Push));
            AppCenter.Start("5274d462-e66f-4fc6-95f8-61bdc822d6c0", typeof(Push));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
