using Prism.Commands;
using System.Windows;

namespace LoL.Core
{
    public interface IDragMove
    {
        DelegateCommand<Window> DragMoveCommand { get; }
    }
}