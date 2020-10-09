using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(0.1, 102.998)]
        [InlineData(1, 15.022)]
        [InlineData(1.5, double.NaN)]
        [InlineData(-1, 996299.338)]
        [InlineData(-5, double.NaN)]
        [InlineData(0, 225.652)]
        public void TestCalc(double x, double exp)
        {
            var actualResult = Program.Calc(x);
            Assert.Equal(exp, actualResult, 3);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(0.26, 0.66, 0.08);
            Assert.Equal(6, res.Length);
            double[] expX = { 0.26, 0.34, 0.42, 0.5, 0.58, 0.66 };
            for (int i = 0; i <= 5; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expX[i], x, 1);
            }
        }
    }
}
