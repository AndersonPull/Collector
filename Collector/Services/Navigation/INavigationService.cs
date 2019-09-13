using System;
using System.Threading.Tasks;
using Collector.ViewModels;

namespace Collector.Services.Navigation
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : BaseVM;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseVM;

        Task NavigateToAsync(Type viewModelType);
    }
}
