using LoL.Core;
using LoL.Main.Common;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows;

namespace LoL.Main.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public DelegateCommand<Window> DragMoveCommand { get; private set; }
        public DelegateCommand MainViewLoadedCommand { get; private set; }

        public MainViewModel(IRegionManager regionManager, IEventAggregator ea, IDragMove dragMove)
        {
            DragMoveCommand = dragMove.DragMoveCommand;
            MainViewLoadedCommand = new DelegateCommand(() =>
            {
                regionManager.RegisterViewWithRegion(PrismRegions.ProfileRegionName, PrismRegions.ProfileRegionView);
                regionManager.RegisterViewWithRegion(PrismRegions.TopMemuRegionName, PrismRegions.TopMemuRegionView);
                regionManager.RegisterViewWithRegion(PrismRegions.MainContentRegionName, PrismRegions.MainContentRegionView);
                regionManager.RegisterViewWithRegion(PrismRegions.FriendsRegionName, PrismRegions.FriendsRegionView);
            });
            ea.GetEvent<MainViewEvent>().Subscribe((t) =>
            {
                Window w = Application.Current.MainWindow;
                switch (t)
                {
                    case MainEventType.Minimize:
                        w.WindowState = WindowState.Minimized;
                        break;

                    case MainEventType.Close:
                        w.Close();
                        break;

                    default:
                        break;
                }
            });
        }
    }
}