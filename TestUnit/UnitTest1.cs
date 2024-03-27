using Bunit;
using System.Security.Cryptography.X509Certificates;
using UnitTestingWeb.Pages;

namespace TestUnit
{
    public class UnitTest1 : TestContext
    {
        [Fact]    
            public void CounterShouldIncrementWhenClicked()
            {
            var cut = RenderComponent<Counter>();

            cut.Find("button").Click();
            }
    }
}