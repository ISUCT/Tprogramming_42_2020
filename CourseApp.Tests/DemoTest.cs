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
        [InlineData(0, -1, -1, 1)] 
        [InlineData(0, 1, 1, 1)] 
        [InlineData(2, 4.1, 0.77, double.NaN)] 
        [InlineData(3, 5.6, 0.44, double.NaN)] 
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
            double[] xItems = { 0.15, 0.26, 0.37, 0.48, 0.56 }; 
            var res = Program.TaskB(0.05, 0.06, xItems); 
            double[] expY = { 77.6, 23.1, 10.7, 5.8, 4 }; 
            for (int i = 0; i <= 2; i++) 
            { 
                var (x, y) = res[i]; 
                Assert.Equal(expY[i], y, 1); 
            } 
        } 

        [Fact] 
        public void TestTaskBSize() 
        { 
            double[] zItems = { 0.15, 0.26, 0.37, 0.48, 0.56 }; 
            var res = Program.TaskB(0.05, 0.06, zItems); 
            Assert.Equal(5, res.Length); 
        } 

        [Fact] 
        public void TestTaskAXnGraterXk() 
        { 
            var res = Program.TaskA(0.05, 0.06, 3, 1, 1); 
            Assert.Empty(res); 
        } 
    } 
}
