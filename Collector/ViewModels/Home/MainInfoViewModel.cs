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
        private FlowObservableCollection<MateriaisModel> itensMenu = null;
        public FlowObservableCollection<MateriaisModel> ItensMenu { get { return itensMenu; } set { this.Set("ItensMenu", ref itensMenu, value); } }

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

            if (ItensMenu.Count > 0)
                ItensMenu.Clear();

            foreach(var material in collection)
            {
                var users = Data.GetList<UserModel>(true);
                var user = users.Where(a => a.Id == App.GetUser.Id).FirstOrDefault();

                var atived = user.CollectorItens.Where(a => a.IdItem == material.IdItem).FirstOrDefault();

                if (atived != null)
                    ItensMenu.Add(atived);
                else
                    ItensMenu.Add(material);
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

                    var Materiais = Data.GetList<MateriaisModel>(false);

                    var material = Materiais.Where(a => a.IdItem == Material.IdItem &&
                                                   a.IdUser ==App.GetUser.Id).FirstOrDefault();

                    if (material == null)
                    {
                        Material.IdUser = App.GetUser.Id;
                        Material.IsAtived = true;
                        Material.NoAtived = false;
                        Data.Insert(Material);
                    }
                    else
                    {
                        Data.Delete(Material);
                    }

                   

                    CarregarMenu();
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
                    await _serviceNavigation.NavigateToAsync<MainTabbedPageViewModel>();
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