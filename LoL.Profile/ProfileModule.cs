using LoL.Profile.ViewModels;
using LoL.Profile.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;

namespace LoL.Profile
{
    public class ProfileModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<ProfileView, ProfileViewModel>();
            ViewModelLocationProvider.Register<SelectProfileView, SelectProfileViewModel>();
            containerRegistry.RegisterForNavigation<ProfileView, ProfileViewModel>();
        }
    }
}