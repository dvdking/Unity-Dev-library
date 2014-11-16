using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevLibrary.Events
{
    public interface IEventSubscriber<in T> where T:AppEvent
    {
        void Receive(T appEvent);
    }
}
