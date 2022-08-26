using LoL.Core;
using Prism.Commands;
using System.Windows;

namespace LoL.Main.Common
{
    internal class DragMove : IDragMove
    {
        public DelegateCommand<Window> DragMoveCommand { get; private set; }

        public DragMove()
        {
            DragMoveCommand = new DelegateCommand<Window>((o) => { o.DragMove(); });
        }
    }
}