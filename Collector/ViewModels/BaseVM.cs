using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Collector.ViewModels
{
    public class BaseVM : ViewModelBase
    {
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}