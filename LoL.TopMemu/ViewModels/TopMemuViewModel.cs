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
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public TopMemuViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
