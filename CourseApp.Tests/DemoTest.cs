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
        [InlineData(1.35, 0.98, 1.14, 4.24, 0.62)]
        public void TestTaskA(double a, double b, double xn, double xk, double dk)
        {
            var res = Program.TaskA(a, b, xn, xk, dk);

            double[] expected = { 420.188474991616, 24.8385462031833, 11.3710561454419, 7.52659360752191, 5.77787349941772, 4.7907434018336 };
            for (int i = 0; i < expected.Length; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expected[i], y, 4);
            }
        }

        [Fact]
        public void TestTaskASize()
        {
            var res = Program.TaskA(1.35, 0.98, 1.14, 4.24, 0.62);
            Assert.Equal(7, res.Length);
        }

        [Fact]
        public void TestTaskB()
        {
            double[] xItems = { 0.35, 1.28, 3.51, 5.21, 4.16 };
            var res = Program.TaskB(1.35, 0.98, xItems);

            double[] expected = { 5.44801944433477, 121.267904730522, 6.0137454909846, 3.89432665100315, 4.89306852696894 };
            for (int i = 0; i < expected.Length; i++)
            {
                var (x, y) = res[i];
                Assert.Equal(expected[i], y, 4);
            }
        }

        [Fact]
        public void TestTaskBSize()
        {
            double[] zItems = { 0.35, 1.28, 3.51, 5.21, 4.16 };
            var res = Program.TaskB(1.35, 0.98, zItems);

            Assert.Equal(5, res.Length);
        }

        [Fact]
        public void TestTaskAXnGraterXk()
        {
            var res = Program.TaskA(1.35, 0.98, 3, 1, 1);
            Assert.Empty(res);
        }
    }
}