using System;

namespace DevLibrary.Common
{
    public class StateMachine:IStateMachine
    {
        private BaseState _currentState;
        private readonly object[] _paramsForNewState;

        public StateMachine()
        {
            _paramsForNewState = new[]
            {
                this
            };
        }

        public void Update()
        {
            if (_currentState != null)
            {
                _currentState.Update();
            }
        }


        public void SetState<T>() where T : BaseState
        {
            SetState(typeof(T));
        }

        public void SetState(Type type)
        {
            if (_currentState != null)
            {
                _currentState.OnExit();
            }

            _currentState = CreateStateFromType(type);

            _currentState.OnEnter();
        }

        private BaseState CreateStateFromType(Type type)
        {
            var state = Activator.CreateInstance(type, _paramsForNewState) as BaseState;

            if (state == null)
            {
                throw new ArgumentException("Can not create state from type: " + type);
            }

            return state;
        }
    }
}