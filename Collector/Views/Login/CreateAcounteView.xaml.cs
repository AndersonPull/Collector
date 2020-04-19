using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Collector.Services.Navigation;
using Collector.ViewModels.Login;
using Collector.ViewModels.ViewModelLocator;
using Xamarin.Forms;

namespace Collector.Views.Login
{
    public partial class CreateAcounteView : ContentPage
    {
        public CreateAcounteView()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");

        }
        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var target = CreateAcounteViewModel._message1[CreateAcounteViewModel._message1.Count - 1];
            MessagesListView.ScrollTo(target, ScrollToPosition.End, false);
        }
    }
}
