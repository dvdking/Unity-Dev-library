using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevLibrary
{
    public interface IStateMachine
    {
        void SetState(Type type);
        void SetState<T>() where T : BaseState;
    }
}
