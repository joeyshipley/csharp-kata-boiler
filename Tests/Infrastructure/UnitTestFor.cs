using AutoMoq;

namespace Tests.Infrastructure
{
    public class UnitTestFor<T> : ArrangeActAssertOn
    {
        protected AutoMoqer Mocker;
        protected T SUT;

        public UnitTestFor()
        {
            SharedBeforeAll();
        }

        private void SharedBeforeAll()
        {
            Mocker = new AutoMoqer();
            SUT = Mocker.Resolve<T>();
        }
    }
}