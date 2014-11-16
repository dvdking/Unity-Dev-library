namespace DevLibrary.Common
{
    public abstract class BaseState
    {
        private readonly StateMachine _ISM;

        /// <summary>
        /// Internal state machine
        /// </summary>
        protected IStateMachine ISM
        {
            get { return _ISM; }
        }

        /// <summary>
        /// Root state machine
        /// </summary>
        protected IStateMachine RSM;

        public BaseState(IStateMachine rootStateMachine)
        {
            _ISM = new StateMachine();
            RSM = rootStateMachine;
        }

        public virtual void OnEnter()
        {
        }

        public virtual void OnExit()
        {
        }

        public virtual void Update()
        {
            _ISM.Update();
        }
    }
}