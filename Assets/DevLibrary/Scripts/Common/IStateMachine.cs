using System;

namespace DevLibrary.Common
{
    public interface IStateMachine
    {
        void SetState(Type type);
        void SetState<T>() where T : BaseState;
    }
}
