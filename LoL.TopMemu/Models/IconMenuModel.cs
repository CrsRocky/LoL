using Prism.Mvvm;

namespace LoL.TopMemu.Models
{
    public class IconMenuModel : BindableBase
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        private string icon;

        public string Icon
        {
            get { return icon; }
            set { SetProperty(ref icon, value); }
        }
    }
}