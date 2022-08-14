using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using LoL.Core;
using System.Windows;
using LoL.Profile.Views;
using System.ComponentModel;
using System.Windows.Media;

namespace LoL.Profile.ViewModels
{
    public class ProfileViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;
        private string level;
        private string onlineSts = "在线";
        private Brush onlineBtnStroke = new SolidColorBrush(onlineBtnStrokeColor);
        private Brush onlineBtnFill = new SolidColorBrush(onlineBtnFillColor);
        private Brush onlineLblForeground = new SolidColorBrush(onlineLblForegroundColor);


        private OnlineState onlineState = OnlineState.Online;
        private static readonly Color onlineBtnStrokeColor = Color.FromRgb(114, 255, 174);
        private static readonly Color onlineBtnFillColor = Color.FromRgb(9, 166, 70);
        private static readonly Color onlineLblForegroundColor = Color.FromRgb(114, 255, 174);
        private static readonly Color offlineStroke = Color.FromRgb(175, 55, 19);
        private static readonly Color offlineFill = Color.FromRgb(1, 10, 19);
        private static readonly Color offLineLblLblForegroundColor = Color.FromRgb(158, 153, 138);

        public DelegateCommand SelectProfileCommand { get; private set; }
        public DelegateCommand MinimizeCommand { get; private set; }
        public DelegateCommand SettingCommand { get; private set; }
        public DelegateCommand CloseCommand { get; private set; }
        public DelegateCommand ChangeOnlineCommand { get; private set; }
        public DelegateCommand InfoCueCommand { get; private set; }


        public string Level
        {
            get { return level; }
            set { SetProperty(ref level, value); }
        }

        public Brush OnlineBtnStroke
        {
            get => onlineBtnStroke;
            set
            {
                onlineBtnStroke = value;
                RaisePropertyChanged();
            }
        }

        public Brush OnlineBtnFill
        {
            get => onlineBtnFill;
            set
            {
                onlineBtnFill = value;
                RaisePropertyChanged();
            }
        }

        public Brush OnlineLblForeground
        {
            get => onlineLblForeground;
            set
            {
                onlineLblForeground = value;
                RaisePropertyChanged();
            }
        }

        public string OnlineSts
        {
            get { return onlineSts; }
            set { SetProperty(ref onlineSts, value); }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { SetProperty(ref userName, value); }
        }


        private Uri profileUri;
        public Uri ProfileUri
        {
            get { return profileUri; }
            set { SetProperty(ref profileUri, value); }
        }


        public ProfileViewModel(IEventAggregator ea)
        {
            _eventAggregator = ea;
            MinimizeCommand = new DelegateCommand(Minimize);
            CloseCommand = new DelegateCommand(Close);
            SelectProfileCommand = new DelegateCommand(SelectProfile);
            ChangeOnlineCommand = new DelegateCommand(ChangeOnline);
            InfoCueCommand = new DelegateCommand(InfoCue);
            Level = "162";
            UserName = "暗裔剑魔";
            ProfileUri = new Uri("pack://application:,,,/LoL.Resources;component/Images/Profiles/25.jpg", UriKind.Absolute);
        }

        void InfoCue()
        {
            

        }

        void ChangeOnline()
        {
            switch (onlineState)
            {
                case OnlineState.Online:
                    OnlineBtnStroke = new SolidColorBrush(offlineStroke);
                    OnlineBtnFill = new SolidColorBrush(offlineFill);
                    OnlineLblForeground = new SolidColorBrush(offLineLblLblForegroundColor);
                    onlineState = OnlineState.Offline;
                    OnlineSts = "离开";
                    break;
                case OnlineState.Offline:
                    OnlineBtnStroke = new SolidColorBrush(onlineBtnStrokeColor);
                    OnlineBtnFill = new SolidColorBrush(onlineBtnFillColor);
                    OnlineLblForeground = new SolidColorBrush(onlineLblForegroundColor);
                    onlineState = OnlineState.Online;
                    OnlineSts = "在线";
                    break;
            }
        }

        void SelectProfile()
        {
            new SelectProfileView().ShowDialog();
        }

        void Close()
        {
            _eventAggregator.GetEvent<MainViewEvent>().Publish(MainEventType.Close);
        }

        void Minimize()
        {
            _eventAggregator.GetEvent<MainViewEvent>().Publish(MainEventType.Minimize);
        }

    }

    public enum OnlineState
    {
        [Description("Online")]
        /// <summary>
        /// 在线
        /// </summary>
        Online,
        [Description("离开")]
        /// <summary>
        /// 离开
        /// </summary>
        Offline,
    }


}
