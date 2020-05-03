using System.Threading.Tasks;
using Collector._Helpers._Translations;
using Collector.Models.Usuarios;
using Collector.Services.Navigation;
using Collector.ViewModels.ViewModelLocator;
using DLToolkit.Forms.Controls;
using Plugin.Multilingual;
using Xamarin.Forms;

namespace Collector
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo;
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

        private static UserModel _getUser;
        public static UserModel GetUser
        {
            get { return _getUser; }
            set { _getUser = value; }
        }
    }
}
