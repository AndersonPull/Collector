using System.Collections.Generic;
using System.Linq;
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
            foreach(var material in collection)
            {
                var atived = App.GetUser.CollectorItens.Where(a => a.Id == material.Id).FirstOrDefault();

                if (atived != null)
                {
                    selected = true;
                    noSelected = false;
                    ItensMenu.Add(atived);
                }

                else
                {
                    selected = false;
                    noSelected = true;
                    ItensMenu.Add(material);
                }
                    
            }
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
                    Material.IdUser = App.GetUser.Id;

                    Data.Insert(Material);

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

        private bool selected;
        public bool Selected { get { return selected; } set { this.Set("Selected", ref selected, value); } }

        private bool noSelected;
        public bool NoSelected { get { return noSelected; } set { this.Set("NoSelected", ref noSelected, value); } }

        private bool buttonCollector;
        public bool ButtonCollector { get { return buttonCollector; } set { this.Set("ButtonCollector", ref buttonCollector, value); } }

      }
}