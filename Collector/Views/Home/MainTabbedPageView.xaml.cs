using BottomBar.XamarinForms;
using Xamarin.Forms;

namespace Collector.Views.Home
{
    public partial class MainTabbedPageView : BottomBarPage
    {
        public MainTabbedPageView()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
