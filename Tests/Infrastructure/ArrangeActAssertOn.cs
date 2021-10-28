using System;

namespace Tests.Infrastructure
{
    public class ArrangeActAssertOn
    {
        protected void Arrange(Action arrange)
        {
            arrange();
        }

        protected void Act(Action act)
        {
            act();
        }

        protected TResult Act<TResult>(Func<TResult> act)
        {
            return act();
        }

        protected void Assert(Action assert)
        {
            assert();
        }
    }
}