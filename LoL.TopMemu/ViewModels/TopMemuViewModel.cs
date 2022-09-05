using LoL.Core;
using LoL.TopMemu.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows;

namespace LoL.TopMemu.ViewModels
{
    public class TopMemuViewModel : BindableBase
    {
        private long coupon;
        private long blueEssernce;

        public DelegateCommand PlayCommand { get; private set; }

        public DelegateCommand<Window> DragMoveCommand { get; private set; }

        public ObservableCollection<string> TextMenu { get; private set; }

        public ObservableCollection<IconMenuModel> IconMenu { get; private set; }

        public long Coupon
        {
            get { return coupon; }
            set { SetProperty(ref coupon, value); }
        }

        public long BlueEssence
        {
            get { return blueEssernce; }
            set { SetProperty(ref blueEssernce, value); }
        }

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
            IconMenu = new ObservableCollection<IconMenuModel>()
            {
                new IconMenuModel()
                {
                    Text = "生涯",
                    Icon ="Career"
                },
                new IconMenuModel()
                {
                    Text = "藏品",
                    Icon ="Collection"
                },
                new IconMenuModel()
                {
                    Text = "战利品",
                    Icon ="Spoils"
                },
                new IconMenuModel()
                {
                    Text = "商城",
                    Icon ="Mall"
                },
            };
            Coupon = 500;
            BlueEssence = 10000;
        }

        void Play()
        {
        }
    }
}