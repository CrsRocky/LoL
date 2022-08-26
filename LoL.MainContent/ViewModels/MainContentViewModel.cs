using Prism.Mvvm;

namespace LoL.MainContent.ViewModels
{
    public class MainContentViewModel : BindableBase
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public MainContentViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}