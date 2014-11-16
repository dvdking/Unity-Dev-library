using System;
using DevLibrary;
using DevLibrary.Common;

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
