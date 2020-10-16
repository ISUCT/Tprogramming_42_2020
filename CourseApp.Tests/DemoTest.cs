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
        [InlineData(-1, 1, 1, double.NaN)]
        [InlineData(-1, -1, -1, -0.269)]
        [InlineData(1, -1, 1, -0.269)]
        [InlineData(9, 9, 1, 0.739)]
        public void TestCalc(double a, double b, double x, double exp)
        {
            var actualResult = Program.Calc(a, b, x);
            Assert.Equal(exp, actualResult, 3);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(2, 0.95, 1, 4, 0.5);
            Assert.Equal(7, res.Length);
            double[] expX = { 1, 1.5, 2, 2.5, 3, 3.5, 4 };
            double[] expY = { -2.119, -0.928, -0.566, -0.413, -0.33, -0.273, -0.23 };
            for (int i = 0; i < 7; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expX[i], x, 3);
                Assert.Equal(expY[i], y, 3);
            }
        }

        [Fact]
        public void TestTaskB()
        {
            double[] xItems = { 1, 2.0809, 0.679, 4, 0.0092 };
            var res = Program.TaskB(2, 0.95, xItems);
            Assert.Equal(5, res.Length);
            double[] expY = { -2.119, -0.533, -4.771, -0.23, -548.661 };
            for (int i = 0; i < 5; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(xItems[i], x, 3);
                Assert.Equal(expY[i], y, 3);
            }
        }
    }
}
