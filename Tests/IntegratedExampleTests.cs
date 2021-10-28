using ConsoleClient.App;
using FluentAssertions;
using NUnit.Framework;
using Tests.Infrastructure;

namespace Tests
{
    public class IntegratedExampleTests
        : ComponentTestFor<IExampleKata>
    {
        [Test]
        public void Test1()
        {
            Arrange(() => {});
            
            var result = Act(() =>
                SUT.Start()
            );
            
            Assert(() => 
            {
                result.Should().Be("NOM NOM NOM");
            });
        }
    }
}