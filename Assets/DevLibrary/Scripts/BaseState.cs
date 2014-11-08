namespace DevLibrary
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

        public BaseState(IStateMachine stateMachine)
        {
            _ISM = new StateMachine();
            RSM = stateMachine;
        }

        public abstract void OnEnter();
        public abstract void OnExit();

        public virtual void Update()
        {
            _ISM.Update();
        }
    }
}