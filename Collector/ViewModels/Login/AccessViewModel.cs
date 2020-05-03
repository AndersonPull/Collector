﻿using System.Windows.Input;
using Collector._Datas;
using Collector.Services.Navigation;
using Collector.ViewModels.Home;
using Collector.Views.PopUpsAlerts;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Collector.ViewModels.Login
{
    public class AccessViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        BaseData Data;

        public AccessViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
            Data = new BaseData();
        }

        public ICommand BackCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<BannerViewModel>();
                });
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (!string.IsNullOrEmpty(entryNickName) && !string.IsNullOrEmpty(entryPassword))
                    {
                        var user = Data.GetUser(entryNickName, entryPassword);
                        if (user != null)
                        {
                            App.GetUser = user;
                            await _serviceNavigation.NavigateToAsync<MainTabbedPageViewModel>();
                        }    
                        else
                            await PopupNavigation.Instance.PushAsync(new PopUpAlertView("login ou senha incorreto", "Verifique seus dados e tente novamente"), true);
                    }
                    else
                        await PopupNavigation.Instance.PushAsync(new PopUpAlertView("Campo Vazio", "Campos login e senha não podem ficar vazios"), true);
                });
            }
        }

        private string entryNickName;
        public string EntryNickName { get { return entryNickName; } set { this.Set("EntryNickName", ref entryNickName, value); } }

        private string entryPassword;
        public string EntryPassword { get { return entryPassword; } set { this.Set("EntryPassword", ref entryPassword, value); } }
    }
}