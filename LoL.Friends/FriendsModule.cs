using LoL.Friends.ViewModels;
using LoL.Friends.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace LoL.Friends
{
    public class FriendsModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<FriendsView, FriendsViewModel>();
            containerRegistry.RegisterForNavigation<FriendsView, FriendsViewModel>();
        }
    }
}