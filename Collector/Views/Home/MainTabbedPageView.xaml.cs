using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Collector.Views.Home
{
    public partial class MainTabbedPageView : Xamarin.Forms.TabbedPage
    {
        public MainTabbedPageView()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
            NavigationPage.SetHasNavigationBar(this, false);
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

        }
    }
}
