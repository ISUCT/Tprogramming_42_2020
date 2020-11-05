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
        [InlineData(1, 1, 1, double.NaN)]
        [InlineData(0.8, 0.4, 1.23, 2.237)]
        [InlineData(0, 1, 2, 2.508)]
        [InlineData(0, -1, 0, double.NaN)]
        public void TestCalcAllZeros(double a, double b, double x, double exp)
        {
            var actualResult = Program.Calc(a, b, x);
            Assert.Equal(exp, actualResult, 3);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(0.8, 0.4, 1, 3, 1);
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
            double[] emptymas = { };
            var result = Program.TaskB(0.8, 0.4, emptymas);
            var a = result.Length;
            Assert.Equal(0, a);
        }

        [Fact]
        public void ArrayOfThreeElements()
        {
            double[] xTest = { 1, 2, 3 };
            var result = Program.TaskB(0.8, 0.4, xTest);
            Assert.Equal(3, result.Length);
        }
    }
}
