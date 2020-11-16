using System;
using Xunit;
using UnitTestingProject;

namespace Tests
{
    public class SimpleArrayTest
    {
        [Fact]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.Equal(4, testInstance.GroceryList.Length);
            Assert.Equal("Bread", testInstance.GroceryList[0]);

        }
        [Fact]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.StartsWith("There are", testInstance.ToString());

        }
    }
}
