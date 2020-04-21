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

        void Send_Clicked(System.Object sender, System.EventArgs e)
        {
            if (EntrySend.Placeholder == "Digite um apelido para fazer o login...")
            {
                EntrySend.Placeholder = "Digite uma senha ...";
                EntrySend.IsPassword = true;
                EntrySend.MaxLength = 6;

            }
            else if(EntrySend.Placeholder == "Digite uma senha ...")
            {
                EntrySend.Placeholder = "Digite seu CEP ...";
                EntrySend.IsPassword = false;
                EntrySend.MaxLength = 8;
                EntrySend.Keyboard = Keyboard.Numeric;

            }

            var target = CreateAcounteViewModel._message1[CreateAcounteViewModel._message1.Count - 1];
            MessagesListView.ScrollTo(target, ScrollToPosition.End, false);
        }

        void Term_Clicked(System.Object sender, System.EventArgs e)
        {
            if (EntrySend.Placeholder == "Digite seu nome...")
            {
                EntrySend.Placeholder = "Digite um apelido para fazer o login...";
                
            }

            var target = CreateAcounteViewModel._message1[CreateAcounteViewModel._message1.Count - 1];
            MessagesListView.ScrollTo(target, ScrollToPosition.End, false);
        }
    }
}
