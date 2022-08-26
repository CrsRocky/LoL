using Prism.Mvvm;

namespace LoL.Friends.ViewModels
{
    public class FriendsViewModel : BindableBase
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public FriendsViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}