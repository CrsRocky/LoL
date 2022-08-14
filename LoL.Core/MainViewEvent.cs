using System;
using Prism.Events;

namespace LoL.Core
{
    public class MainViewEvent : PubSubEvent<MainEventType> { }

    public enum MainEventType
    {
        Minimize,
        Close
    }
}
