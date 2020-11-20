using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0, 0, 0, double.NaN)]

        public void TestCalcAllZero(double a, double b, double x, double exp)
        {
            var actualResult = Program.Calc(a, b, x);
            Assert.Equal(exp, actualResult);
        }

        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void NumenatorEqualZero()
        {
            var actualResult = Program.Calc(1, 2, 2);
            Assert.Equal(double.NaN, actualResult);
        }

        [Fact]
        public void DenominatorEqualZero()
        {
            var actualResult = Program.Calc(1, 1, 0);
            Assert.Equal(double.NaN, actualResult);
        }

        [Fact]
        public void LogEqualZero()
        {
            var actualResult = Program.Calc(1, 0, 0);
            Assert.Equal(double.NaN, actualResult);
        }

        [Fact]
        public void ArrayLenght()
        {
            var actualResult = Program.TaskA(2, 1.1, 0.08, 1.08, 0.2);
            Assert.Equal(6, actualResult.Length);
        }

        [Fact]
        public void Array()
        {
            var actualResult = Program.TaskA(2, 1.1, 1, 6, 1);
            Assert.Equal(6, actualResult.Length);
            double[] expX = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i <= 5; i++)
            {
                var (x, y) = actualResult[i];
                Assert.Equal(expX[i], x, 1);
            }
        }

        [Fact]
        public void ArrayOfThreeElements()
        {
            double[] xTest = { 1, 2, 3 };
            var actualResult = Program.TaskB(2, 1.1, xTest);
            Assert.Equal(3, actualResult.Length);
        }

        [Fact]
        public void ArrayOfZeroElements()
        {
            double[] xTest = { };
            var actualResult = Program.TaskB(2, 1, xTest);
            var a = actualResult.Length;
            Assert.Equal(0, a);
        }

        [Fact]
        public void RootOfFive()
        {
            var actualResult = Program.CubeRoot(-32);
            Assert.Equal(-2, actualResult);
        }

        [Fact]
        public void RootOfFive2()
        {
            var actualResult = Program.CubeRoot(32);
            Assert.Equal(2, actualResult);
        }
    }
}