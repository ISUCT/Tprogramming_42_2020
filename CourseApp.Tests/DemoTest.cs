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
        [InlineData(0, 0, 0, double.NaN)]
        [InlineData(1.1, 0.09, 1.2, 4.791)]
        [InlineData(1, 1, 1, double.NaN)]
        [InlineData(1, 0, 1, double.PositiveInfinity)]
        public void TestCalcAllZeros(double a, double b, double x, double exp)
        {
            var actualResult = Program.Calc(a, b, x);
            Assert.Equal(exp, actualResult, 3);
        }

        [Theory]
        [InlineData(1.1, 0.09, 1.2, 2.2, 0.2, 6)]
        public void TestTaskA(double a, double b, double xn, double xk, double dx, double exp)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            Assert.Equal(exp, res.Length);
            double[] expX = { 1.2, 1.4, 1.6, 1.8, 2.0, 2.2 };
            for (int i = 0; i <= 5; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expX[i], x, 1);
            }
        }

        [Fact]
        public void TestTaskB()
        {
            int i = 0;
            double[] xItems = { 1.21, 1.76, 2.53, 3.48, 4.52 };
            var res = Program.TaskB(1.1, 0.09, xItems);
            Assert.Equal(5, xItems.Length);
            double[] expmas = { 5.865, 0.445, 0.501, 0.496, 0.489 };
            foreach (var item in res)
            {
                var (x, y) = item;
                Assert.Equal(expmas[i], y, 3);
                i++;
            }
        }
    }
}