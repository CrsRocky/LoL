using LoL.Core;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace LoL.TopMemu.ViewModels
{
    public class TopMemuViewModel : BindableBase
    {
        public DelegateCommand PlayCommand { get; private set; }

        public DelegateCommand<Window> DragMoveCommand { get; private set; }

        public TopMemuViewModel(IDragMove dragMove)
        {
            DragMoveCommand = dragMove.DragMoveCommand;
            PlayCommand = new DelegateCommand(Play);
        }

        void Play()
        {
        }
    }
}