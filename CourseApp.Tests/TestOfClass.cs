using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestOfClass
    {
        [Theory]
        [InlineData(0)]
        [InlineData(12.8)]
        [InlineData(-325.1)]
        [InlineData(122.6 / 9.5)]
        [InlineData(65.9)]
        public void TestValuesofPropertiesSpeed(double speed)
        {
            Car car1 = new Car(speed);
            var resultSpeedBeforeStop = car1.Speed;
            car1.Go();
            car1.Stop();
            var resultSpeedAfterStop = car1.Speed;
            if (speed < 0)
            {
                speed = 0;
            }

            Assert.Equal(speed, resultSpeedBeforeStop);
            Assert.Equal(0, resultSpeedAfterStop);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(12.8, 100.3)]
        [InlineData(-325.1, 3.5)]
        [InlineData(122.6 / 9.5, 23.3)]
        [InlineData(65.9, -23)]
        public void TestValuesofPropertiesTime(double speed, double time)
        {
            Car car1 = new Car(speed, time);
            var resultTimeWay = car1.TimeWay;
            car1.Go();
            car1.Stop();
            if (time < 0)
            {
                time = 0;
            }

            Assert.Equal(time, resultTimeWay);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(12.8, 100.3, 1283.84)]
        [InlineData(-325.1, 3.5, 0)]
        [InlineData(122.6 / 9.5, 23.3, 300.693)]
        [InlineData(65.9, -23, 0)]
        public void TestValuesofPropertiesWay(double speed, double time, double expWay)
        {
            Car car1 = new Car(speed, time);
            car1.Go();
            var resultWay = car1.Way;
            car1.Stop();
            Assert.Equal(expWay, resultWay, 3);
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
        public void TestPositiveWtihZeroGetInfo_01()
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
        public void TestPositiveWtihZeroGetInfo_02()
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
        public void TestNegativeWtihZeroGetInfo()
        {
            Car car1 = new Car(0, -244.45);
            car1.Go();
            Tuple<double, double> resultBeforeFirst = car1.GetInfo();
            car1.Stop();
            Tuple<double, double> resultAfterFirst = car1.GetInfo();
            Assert.Equal(0, resultBeforeFirst.Item1);
            Assert.Equal(0, resultBeforeFirst.Item2);
            Assert.Equal(0, resultAfterFirst.Item1);
            Assert.Equal(0, resultAfterFirst.Item2);
        }

        [Fact]
        public void TestPositiveValues_01()
        {
            Car car1 = new Car(1232.7, 2324.3);
            car1.Go();
            Tuple<double, double> resultBeforeFIrst = car1.GetInfo();
            car1.Stop();
            Tuple<double, double> resultAfterFIrst = car1.GetInfo();
            Assert.Equal(1232.7, resultBeforeFIrst.Item1);
            Assert.Equal(2865164.61, resultBeforeFIrst.Item2, 2);
            Assert.Equal(0, resultAfterFIrst.Item1);
            Assert.Equal(2865164.61, resultAfterFIrst.Item2, 2);
        }

        [Fact]
        public void TestPositiveValues_02()
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
        public void TestNegativeValues()
        {
            Car car1 = new Car(-546.2, -82.9);
            car1.Go();
            Tuple<double, double> resultBeforeFIrst = car1.GetInfo();
            car1.Stop();
            Tuple<double, double> resultAfterFIrst = car1.GetInfo();
            Assert.Equal(0, resultBeforeFIrst.Item1);
            Assert.Equal(0, resultBeforeFIrst.Item2);
            Assert.Equal(0, resultAfterFIrst.Item1);
            Assert.Equal(0, resultAfterFIrst.Item2);
        }
    }
}