using ConsoleClient.App;
using FluentAssertions;
using NUnit.Framework;
using Tests.Infrastructure;

namespace Tests
{
    public class MockedExampleTests
        : UnitTestFor<ExampleKata>
    {
        [Test]
        public void Test1()
        {
            Arrange(() => 
            {
                Mocker.GetMock<IExampleDependency>()
                    .Setup(x => x.GetMessage())
                    .Returns("I CAN HAZ NOM NOMS");
            });
            
            var result = Act(() =>
                SUT.Start()
            );
            
            Assert(() => 
            {
                result.Should().Be("I CAN HAZ NOM NOMS");
            });
        }
    }
}