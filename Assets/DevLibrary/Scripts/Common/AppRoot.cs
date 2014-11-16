using System;
using UnityEngine;

namespace DevLibrary.Common
{
    public abstract class AppRoot : MonoBehaviour
    {
        private readonly StateMachine _stateMachine = new StateMachine();
        private void Start()
        {
            Type startingState = GetStartState();
            _stateMachine.SetState(startingState);
        }

        private void Update()
        {
            _stateMachine.Update();
        }

        protected abstract Type GetStartState();
    }
}