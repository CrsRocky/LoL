using LoL.TopMemu.ViewModels;
using LoL.TopMemu.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;

namespace LoL.TopMemu
{
    public class TopMemuModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<TopMemuView, TopMemuViewModel>();
            containerRegistry.RegisterForNavigation<TopMemuView, TopMemuViewModel>();
        }
    }
}