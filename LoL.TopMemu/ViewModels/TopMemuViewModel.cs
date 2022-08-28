using LoL.Core;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows;

namespace LoL.TopMemu.ViewModels
{
    public class TopMemuViewModel : BindableBase
    {
        public DelegateCommand PlayCommand { get; private set; }

        public DelegateCommand<Window> DragMoveCommand { get; private set; }

        public ObservableCollection<string> TextMenu { get; private set; }

        public ObservableCollection<string> IconMenu { get;private set; }

        public TopMemuViewModel(IDragMove dragMove)
        {
            DragMoveCommand = dragMove.DragMoveCommand;
            PlayCommand = new DelegateCommand(Play);
            TextMenu = new ObservableCollection<string>()
            {
                "主页",
                "云顶之弈",
                "冠军杯赛",
            };
            IconMenu = new ObservableCollection<string>()
            {
                "生涯",
                "藏品",
                "战利品",
                "商城",
            };
        }

        void Play()
        {
        }
    }
}