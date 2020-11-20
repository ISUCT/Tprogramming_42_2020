using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestOfClassBicycle
    {
        [Theory]
        [InlineData(49.9, 49.9)]
        public void TestValuesofPropertiesSpeed(double speed, double exp)
        {
            Bicycle bicycle1 = new Bicycle(speed);
            var resultSpeedBeforeStop = bicycle1.Speed;
            bicycle1.Go();
            bicycle1.Stop();
            var resultSpeedAfterStop = bicycle1.Speed;
            Assert.Equal(exp, resultSpeedBeforeStop);
            Assert.Equal(0, resultSpeedAfterStop);
        }

        [Fact]
        public void TestOfZeroGetInfo()
        {
            Bicycle bicycle1 = new Bicycle(0, 0);
            bicycle1.Go();
            Tuple<double, double> resultBefore = bicycle1.GetInfo();
            bicycle1.Stop();
            Tuple<double, double> resultAfter = bicycle1.GetInfo();
            Assert.Equal(0, resultBefore.Item1);
            Assert.Equal(0, resultBefore.Item2);
            Assert.Equal(0, resultAfter.Item1);
            Assert.Equal(0, resultAfter.Item2);
        }

        [Fact]
        public void TestNoExceptionIsThrownWhenNegativeValues()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Bicycle(23.5, -23));
            Assert.Equal("Timeway must positive or zero equals. (Parameter 'value')", ex.Message);
        }
    }
}