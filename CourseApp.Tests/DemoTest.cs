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
        [InlineData(1, 1, 1, 4.348)]
        [InlineData(2, 2, 2, 49.592)]
        [InlineData(-2, -2, 2, double.NaN)]
        [InlineData(0, 0, 0, 0)]
        public void TestCalcAllZeros(double a, double b, double x, double exp)
        {
            var actualResult = Program.Calc(a, b, x);
            Assert.Equal(exp, actualResult, 3);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(2, 4.1, 1, 3, 1);
            Assert.Equal(3, res.Length);
            double[] expX = { 1, 2, 3 };
            for (int i = 0; i <= 2; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expX[i], x, 1);
            }
        }

        [Fact]
        public void TestTaskB()
        {
            double[] xItems = { 9.1, 0.28, 0.06, 0.26, 3.05 };
            var res = Program.TaskB(0.12, 2, xItems);
            double[] expY = { 634.8, 0.5, 0.1, 0.4, 53.8 };
            for (int i = 0; i <= 4; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expY[i], y, 1);
            }
        }
    }
}
