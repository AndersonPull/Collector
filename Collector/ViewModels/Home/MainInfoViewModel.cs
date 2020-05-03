﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Collector._Datas;
using Collector.Models.Home;
using Collector.Models.Usuarios;
using Collector.Services.Home;
using Collector.Services.Navigation;
using Collector.ViewModels.Home.QuemSomos;
using Collector.ViewModels.Login;
using DLToolkit.Forms.Controls;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Collector.ViewModels.Home
{
    public class MainInfoViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        MenuService _service;
        public FlowObservableCollection<MateriaisModel> ItensMenu { get; set; }
        BaseData Data;
        public MainInfoViewModel(INavigationService serviceNavigation)
        {
            ItensMenu = new FlowObservableCollection<MateriaisModel>();
            _service = new MenuService();
            _serviceNavigation = serviceNavigation;
            Data = new BaseData();

            if (App.GetUser.Image == null)
                App.GetUser.Image = "img_Default.png";

            if (App.GetUser.IsCollector)
                buttonCollector = false;
            else
                buttonCollector = true;

            user = App.GetUser;

            CarregarMenu();
        }

        public void CarregarMenu()
        {
            var collection = _service.ItensMenu();
            ItensMenu.AddRange(collection);
        }

        public ICommand SairCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<AccessViewModel>();
                });
            }
        }

        public ICommand ItemSelectedCommand
        {
            get
            {
                return new Command(async (value) =>
                {
                    MateriaisModel Material = value as MateriaisModel;

                    UserModel userId = new UserModel();
                    userId = App.GetUser;

                    Material.user = userId;
                    App.GetUser.CollectorItens = new List<MateriaisModel>();
                    App.GetUser.CollectorItens.Add(Material);
                    Data.Update(Material);

                });
            }
        }

        public ICommand QuemSomosCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<QuemSomosViewModel>();
                });
            }
        }

        public ICommand IsCollector
        {
            get
            {
                return new Command(async () =>
                {
                    App.GetUser.IsCollector = true;
                    Data.Update(App.GetUser);
                });
            }
        }

        public ICommand SaveEditCommand
        {
            get
            {
                return new Command(async () =>
                {
                    
                    Data.Update(App.GetUser);
                });
            }
        }

        public ICommand ParaOndeVamosCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<ParaOndeVAmosViewModel>();
                });
            }
        }

        public ICommand ColaboreCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _serviceNavigation.NavigateToAsync<ColaboreViewModel>();
                });
            }
        }

        private object user;
        public object User { get { return user; } set { this.Set("User", ref user, value); } }

        private bool buttonCollector;
        public bool ButtonCollector { get { return buttonCollector; } set { this.Set("ButtonCollector", ref buttonCollector, value); } }

    }
}