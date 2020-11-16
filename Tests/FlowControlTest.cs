using System;
using Xunit;
using UnitTestingProject;

namespace Tests
{
    public class FlowControlTest
    {
        private FlowControl CreateFlowControl()
        {
            return new FlowControl();
        }

        [Fact]
        public void FavoriteBlueTest()
        {
            var testInstance = CreateFlowControl();
            Assert.True(testInstance.IsYourFavoriteColorBlue("blue"));
            Assert.False(testInstance.IsYourFavoriteColorBlue("green"));

        }
        [Fact]
        public void FavoriteRedTest()
        {
            var testInstance = CreateFlowControl();
            Assert.True(testInstance.IsYourFavoriteColorRed("red"));
            Assert.False(testInstance.IsYourFavoriteColorRed("green"));

        }
        [Fact]
        public void FavoriteGreenTest()
        {
            var testInstance = CreateFlowControl();
            Assert.True(testInstance.IsYourFavoriteColorGreen("green"));
            Assert.False(testInstance.IsYourFavoriteColorGreen("yellow"));

        }
        [Fact]
        public void FavoriteYellowTest()
        {
            var testInstance = CreateFlowControl();
            Assert.True(testInstance.IsYourFavoriteColorYellow("yellow"));
            Assert.False(testInstance.IsYourFavoriteColorYellow("green"));

        }
        [Fact]
        public void PrimaryOrSecondaryTest()
        {
            var testInstance = CreateFlowControl();
            Assert.Equal("Primary", testInstance.PrimaryOrSecondary("blue"));
            Assert.Equal("Secondary", testInstance.PrimaryOrSecondary("green"));

        }
        [Fact]
        public void PrimaryOrSecondarySwitchTest()
        {
            var testInstance = CreateFlowControl();
            Assert.Equal("Primary", testInstance.PrimaryOrSecondarySwitch("blue"));
            Assert.Equal("Secondary", testInstance.PrimaryOrSecondarySwitch("green"));

        }
        [Fact]
        public void PrimaryOrSecondaryCompoundTest()
        {
            var testInstance = CreateFlowControl();
            Assert.Equal("Primary", testInstance.PrimaryOrSecondaryCompound("blue"));
            Assert.Equal("Secondary", testInstance.PrimaryOrSecondaryCompound("green"));

        }
        [Fact]
        public void GradeLetterTest()
        {
            var testInstance = CreateFlowControl();
            Assert.Equal("C", testInstance.GradeLetter(70));
            Assert.Equal("F", testInstance.GradeLetter(50));
        }
        [Fact]
        public void IsYourNameNotBruceTest()
        {
            var testInstance = CreateFlowControl();
            Assert.StartsWith("Can we call", testInstance.IsYourNameNotBruce("NotBruce"));
            Assert.StartsWith("G'day", testInstance.IsYourNameNotBruce("Bruce"));
        }
    }
}
