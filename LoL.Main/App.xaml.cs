using LoL.Core;
using LoL.Friends;
using LoL.Main.Common;
using LoL.Main.ViewModels;
using LoL.Main.Views;
using LoL.MainContent;
using LoL.Profile;
using LoL.TopMemu;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using System.Windows;

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
            containerRegistry.RegisterSingleton<IDragMove, DragMove>();
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