using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Collector.Models.Usuarios;
using Xamarin.Forms;

namespace Collector.ViewModels.Home.Usuarios
{
    public class shimmerViewModel : BindableObject
    {
        private ObservableCollection<Products> getProducts;

        public ObservableCollection<Products> GetProducts
        {
            get { return getProducts; }
            set
            {
                getProducts = value;
                OnPropertyChanged();
            }
        }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public shimmerViewModel()
        {
            PerformShimmerTaskAsync();
        }

        private async Task PerformShimmerTaskAsync()
        {

            GetProducts = new ObservableCollection<Products>(new List<Products> {

                new Products
                {
                    Title = "Something",
                    Subtitle = "fake data",
                    IsBusy = true
                },
                new Products
                {
                    Title = "Something",
                    Subtitle = "fake data",
                    IsBusy = true
                },
                new Products
                {
                    Title = "Something",
                    Subtitle = "fake data",
                    IsBusy = true
                },
                new Products
                {
                    Title = "Something",
                    Subtitle = "fake data",
                    IsBusy = true
                },

            });

            this.IsBusy = true;

            await Task.Delay(3000);

            this.IsBusy = false;

            GetProducts = new ObservableCollection<Products>(new List<Products> {
                new Products
                {
                    Title = "Resturant Tokio Cafe",
                    Subtitle = "Non-Directional Beacon",
                    Image = "resturant.png",
                },
                new Products
                {
                    Title = "Resturant Texas Cafe ",
                    Subtitle = "Non-Directional Beacon",
                    Image = "resturant2.png",
                },
                new Products
                {
                    Title = "Resturant Newyork Cafe",
                    Subtitle = "Non-Directional Beacon",
                    Image = "resturant3.png",
                },
                new Products
                {
                    Title = "Resturant Florida Cafe",
                    Subtitle = "Non-Directional Beacon",
                    Image = "resturant4.png",
                },
            });
        }
    }
}

