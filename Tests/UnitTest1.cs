using System;
using Xunit;
using UnitTestingProject;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var testInstance = new Class1();
            var testResult = testInstance.AddTwo(5, 6);
            Assert.Equal(11, testResult);
        }
    }
}
