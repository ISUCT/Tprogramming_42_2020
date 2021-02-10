using System;
using Xunit;

namespace CourseApp.Tests
{
    public class FoxTests
    {
        [Theory]
        [InlineData("Li", 5, "white", "Имя:Li\n Возраст:5\n Цвет:white")]
        public void TestInfo(string a, int b, string c, string exp)
        {
            Fox actualResult = new Fox(a, b, c);
            Assert.Equal(exp, actualResult.ToString());
        }
    }
}