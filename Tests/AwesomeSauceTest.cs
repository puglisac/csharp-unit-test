using System;
using Xunit;
using UnitTestingProject;

namespace Tests
{
    public class AwesomeSauceTest
    {
        [Fact]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            Assert.True(testInstance.isSauceAwesome("Cholula"));
            Assert.False(testInstance.isSauceAwesome("Ketchup"));

        }
    }
}
