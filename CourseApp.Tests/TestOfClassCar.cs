using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestOfClassCar
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(12.8, 12.8)]
        [InlineData(122.6 / 9.5, 122.6 / 9.5)]
        [InlineData(65.9, 65.9)]
        public void TestValuesofPropertiesSpeed(double speed, double exp)
        {
            Car car1 = new Car(speed);
            var resultSpeedBeforeStop = car1.Speed;
            car1.Go();
            car1.Stop();
            var resultSpeedAfterStop = car1.Speed;
            Assert.Equal(exp, resultSpeedBeforeStop);
            Assert.Equal(0, resultSpeedAfterStop);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(12.8, 100.3, 100.3)]
        [InlineData(122.6 / 9.5, 23.3, 23.3)]
        public void TestValuesofPropertiesTime(double speed, double time, double expTime)
        {
            Car car1 = new Car(speed, time);
            var resultTimeWay = car1.TimeWay;
            car1.Go();
            car1.Stop();
            Assert.Equal(expTime, resultTimeWay);
        }

        [Fact]
        public void TestOfZeroGetInfo()
        {
            Car car1 = new Car(0, 0);
            car1.Go();
            Tuple<double, double> resultBefore = car1.GetInfo();
            car1.Stop();
            Tuple<double, double> resultAfter = car1.GetInfo();
            Assert.Equal(0, resultBefore.Item1);
            Assert.Equal(0, resultBefore.Item2);
            Assert.Equal(0, resultAfter.Item1);
            Assert.Equal(0, resultAfter.Item2);
        }

        [Fact]
        public void TestPositiveWtihZeroGetInfo01()
        {
            Car car1 = new Car(234.7, 0);
            car1.Go();
            Tuple<double, double> resultBeforeFirst = car1.GetInfo();
            car1.Stop();
            Tuple<double, double> resultAfterFirst = car1.GetInfo();
            Assert.Equal(234.7, resultBeforeFirst.Item1);
            Assert.Equal(0, resultBeforeFirst.Item2);
            Assert.Equal(0, resultAfterFirst.Item1);
            Assert.Equal(0, resultAfterFirst.Item2);
        }

        [Fact]
        public void TestPositiveWtihZeroGetInfo02()
        {
            Car car2 = new Car(0, 567.9);
            car2.Go();
            Tuple<double, double> resultBeforeSecond = car2.GetInfo();
            car2.Stop();
            Tuple<double, double> resultAfterSecond = car2.GetInfo();
            Assert.Equal(0, resultBeforeSecond.Item1);
            Assert.Equal(0, resultBeforeSecond.Item2);
            Assert.Equal(0, resultAfterSecond.Item1);
            Assert.Equal(0, resultAfterSecond.Item2);
        }

        [Fact]
        public void TestPositiveValues()
        {
            Car car2 = new Car(1.7, 3 / 0.47);
            car2.Go();
            Tuple<double, double> resultBeforeSecond = car2.GetInfo();
            car2.Stop();
            Tuple<double, double> resultAfterSecond = car2.GetInfo();
            Assert.Equal(1.7, resultBeforeSecond.Item1);
            Assert.Equal(10.851, resultBeforeSecond.Item2, 3);
            Assert.Equal(0, resultAfterSecond.Item1);
            Assert.Equal(10.851, resultAfterSecond.Item2, 3);
        }

        [Fact]
        public void TestNoExceptionIsThrownWhenNegativeValues()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Car(-325.1, 3.5));
            Assert.Equal("Speed must positive or zero equals. (Parameter 'value')", ex.Message);
        }
    }
}