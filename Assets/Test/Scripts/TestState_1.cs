
using DevLibrary;
using DevLibrary.Common;
using UnityEngine;

namespace Test
{
    public class TestState_1:BaseState
    {
        public TestState_1(IStateMachine rootStateMachine) 
            : base(rootStateMachine)
        {
        }

        public override void OnEnter()
        {
            Debug.Log("Test state 1  enter");
        }

        public override void OnExit()
        {
            Debug.Log("Test state 1 exit");
        }
    }
}
