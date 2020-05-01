using System;
using System.Timers;
using Collector.ViewModels.Login;
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
            if (EntrySend.Placeholder == "Digite um apelido para o login...")
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
            else if (EntrySend.Placeholder == "Digite seu CEP ...")
            {
                EntrySend.Placeholder = "Digite o número da sua residencia";
                EntrySend.IsPassword = false;
                EntrySend.MaxLength = 8;
                EntrySend.Keyboard = Keyboard.Numeric;
            }

            var target = CreateAcounteViewModel.Message1[CreateAcounteViewModel.Message1.Count - 1];
            MessagesListView.ScrollTo(target, ScrollToPosition.End, false);
        }

        void Term_Clicked(System.Object sender, System.EventArgs e)
        {
            if (EntrySend.Placeholder == "Digite seu nome...")
                EntrySend.Placeholder = "Digite um apelido para o login...";

            var target = CreateAcounteViewModel.Message1[CreateAcounteViewModel.Message1.Count - 1];
            MessagesListView.ScrollTo(target, ScrollToPosition.End, false);
        }
        
    }
}