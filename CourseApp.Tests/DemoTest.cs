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
        [InlineData(-2.5, 3.4, 3.5, 6.5, 0.6)]
        public void TestTaskA(double a, double b, double xn, double xk, double dk)
        {
            var res = Program.TaskA(a, b, xn, xk, dk);

            double[] expected = { 0.19301, 0.04317, 0.00748, 870.10154, 1557.86456, 2575.23847 };
            for (int i = 0; i < expected.Length; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expected[i], y, 4);
            }
        }

        [Fact]
        public void TestTaskASize()
        {
            var res = Program.TaskA(-2.5, 3.4, 3.5, 6.5, 0.6);
            Assert.Equal(6, res.Length);
        }

        [Fact]
        public void TestTaskB()
        {
            double[] xItems = { 2.89, 3.54, 5.21, 6.28, 3.48 };
            var res = Program.TaskB(-2.5, 3.4, xItems);

            double[] expected = { 1.82138, 0.17331, 761.81663, 2774.86012, 0.20386 };

            for (int i = 0; i < expected.Length; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expected[i], y, 4);
            }
        }

        [Fact]
        public void TestTaskBSize()
        {
            double[] zItems = { 2.89, 3.54, 5.21, 6.28, 3.48 };
            var res = Program.TaskB(-2.5, 3.4, zItems);

            Assert.Equal(5, res.Length);
        }

        [Fact]
        public void TestTaskAXnGraterXk()
        {
            var res = Program.TaskA(-2.5, 3.4, 3, 1, 1);
            Assert.Empty(res);
        }
    }
}