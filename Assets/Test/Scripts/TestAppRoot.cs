using System;
using DevLibrary;

namespace Test
{
    public class TestAppRoot:AppRoot
    {
        protected override Type GetStartState()
        {
            return typeof (TestState_1);
        }
    }
}
