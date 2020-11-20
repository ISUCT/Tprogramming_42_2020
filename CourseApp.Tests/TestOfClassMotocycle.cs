using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestOfClassMotocycle
    {
        [Theory]
        [InlineData(409, 409)]
        public void TestValuesofPropertiesSpeed_Motocycle(double speed, double exp)
        {
            Motocycle motocycle1 = new Motocycle(speed);
            var resultSpeedBeforeStop = motocycle1.Speed;
            motocycle1.Go();
            motocycle1.Stop();
            var resultSpeedAfterStop = motocycle1.Speed;
            Assert.Equal(exp, resultSpeedBeforeStop);
            Assert.Equal(0, resultSpeedAfterStop);
        }

        [Fact]
        public void TestOfZeroGetInfo_Motocycle()
        {
            Motocycle motocycle1 = new Motocycle(0, 0);
            motocycle1.Go();
            Tuple<double, double> resultBefore = motocycle1.GetInfo();
            motocycle1.Stop();
            Tuple<double, double> resultAfter = motocycle1.GetInfo();
            Assert.Equal(0, resultBefore.Item1);
            Assert.Equal(0, resultBefore.Item2);
            Assert.Equal(0, resultAfter.Item1);
            Assert.Equal(0, resultAfter.Item2);
        }

        [Fact]
        public void TestNoExceptionIsThrownWhenNegativeValues()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Motocycle(412, 0));
            Assert.Equal("Speed must positive or zero equals or less 410. (Parameter 'value')", ex.Message);
        }
    }
}