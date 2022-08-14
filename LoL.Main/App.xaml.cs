using LoL.Main.Views;
using Prism.Ioc;
using System.Windows;
using LoL.Main.ViewModels;
using Prism.Mvvm;
using Prism.Modularity;
using LoL.Profile;
using LoL.TopMemu;
using LoL.MainContent;
using LoL.Friends;

namespace LoL.Main
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<MainView, MainViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<TopMemuModule>();
            moduleCatalog.AddModule<ProfileModule>();
            moduleCatalog.AddModule<MainContentModule>();
            moduleCatalog.AddModule<FriendsModule>();
        }


    }
}
