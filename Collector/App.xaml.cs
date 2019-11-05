using System.Threading.Tasks;
using Collector.Services.Navigation;
using Collector.ViewModels.ViewModelLocator;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

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
