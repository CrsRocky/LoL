using LoL.MainContent.ViewModels;
using LoL.MainContent.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;

namespace LoL.MainContent
{
    public class MainContentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<MainContentView, MainContentViewModel>();
            containerRegistry.RegisterForNavigation<MainContentView, MainContentViewModel>();
        }
    }
}