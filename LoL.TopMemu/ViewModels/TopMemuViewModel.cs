using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL.TopMemu.ViewModels
{
    public class TopMemuViewModel : BindableBase
    {
        public DelegateCommand PlayCommand;

        public TopMemuViewModel()
        {
            PlayCommand = new DelegateCommand(Play);
        }

        void Play()
        {
           
        }
    }
}
