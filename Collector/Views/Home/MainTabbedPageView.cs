using System;

using Xamarin.Forms;

namespace Collector.Views.Home
{
    public class MainTabbedPageView : ContentPage
    {
        public MainTabbedPageView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

