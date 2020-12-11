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
        [InlineData(1, 1, 0, double.NaN)]
        [InlineData(4.1, 2.7, 1.5, -147.114)]
        [InlineData(0, 1, 3, -25.023)]
        [InlineData(0, 0, 5, 0)]

        public void TestCalcAllZeros(double a, double b, double x, double exp)
        {
            var actualResult = Program.Calc(a, b, x);
            Assert.Equal(exp, actualResult, 3);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(4.1, 2.7, 1.5, 0.4, 3.5);
            Assert.Equal(6, res.Length);
            double[] expY = { -147.114, -41765.494, 2713.874, 330.344, 121.962, 65.433 };
            for (int i = 0; i < 6; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expY[i], y, 1);
            }
        }

        [Fact]
        public void TestTaskB()
        {
            double[] emptymas = { };
            var result = Program.TaskB(4.1, 2.7, emptymas);
            var a = result.Length;
            Assert.Equal(0, a);
        }

        [Fact]
        public void ArrayOfThreeElements()
        {
            double[] xTest = { 1, 2, 3 };
            var result = Program.TaskB(4.1, 2.7, xTest);
            Assert.Equal(3, result.Length);
        }
    }
}
