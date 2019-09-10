using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Collector.Views.Home
{
    public partial class MainTabbedPageView : Xamarin.Forms.TabbedPage
    {
        public MainTabbedPageView()
        {
            InitializeComponent();
            var pages = Children.GetEnumerator();
            pages.MoveNext(); // First page
            pages.MoveNext(); // Second page
            CurrentPage = pages.Current;
            NavigationPage.SetBackButtonTitle(this, "");
            NavigationPage.SetHasNavigationBar(this, false);
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);


        }
    }
}
