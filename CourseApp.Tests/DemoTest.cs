using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0, 0, double.NaN)]
        [InlineData(1, 1, double.PositiveInfinity)]
        [InlineData(1, 2, 1.965)]
        [InlineData(1, 3, 2.097)]
        [InlineData(0, -6, 1.727)]
        [InlineData(3, -3, 6562.097)]
        [InlineData(5, -3, 390626.097)]
        [InlineData(46, -2, 97336.965)]

        public void TestCalcAllZeros(double a,  double x, double exp)
        {
            var actualResult = Program.Calc(a, x);
            Assert.Equal(exp, actualResult, 3);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(2, 1, 3, 1);
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
            int i = 0;
            double[] xItems = { 1, 2, 3, 4, 5 };
            double[] expY = { 1, 2, 3, 4, 5, 6 };
            var res = Program.TaskB(1.6, xItems);
            Assert.Equal(5, xItems.Length);
            foreach (var item in res)
            {
                var (x, y) = res[i];
                Assert.Equal(expY[i], x, 1);
            }
        }
    }
}
