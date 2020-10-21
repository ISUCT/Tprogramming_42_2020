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
        [InlineData(-0.1, -0.2, -4.81)]
        [InlineData(-0.1, 0.2, 5.23)]
        [InlineData(1, 2, 0.56)]
        [InlineData(-1, -2, -0.56)]
        public void TestCalcAllZeros(double b, double x, double exp)
        {
            var actualResult = Program.Calc(b, x);
            Assert.Equal(exp, actualResult, 2);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(4.1, 1, 3, 1);
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
            double[] xItems = { 1.1, 4.4, 3.6, 5.7, 8.9 };
            var res = Program.TaskB(5, xItems);
            double[] expX = { 0.3, 0.2, 0.3, 0.1, 0.2 };
            for (int i = 0; i <= 2; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expX[i], y, 1);
            }
        }
    }
}
