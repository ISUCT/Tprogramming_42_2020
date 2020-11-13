using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestOfClass
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(12.8, 12.8)]
        [InlineData(-325.1, 0)]
        [InlineData(122.6 / 9.5, 122.6 / 9.5)]
        [InlineData(65.9, 65.9)]
        public void TestValuesofPropertiesSpeed_Car(double speed, double exp)
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
        [InlineData(-325.1, 3.5, 3.5)]
        [InlineData(122.6 / 9.5, 23.3, 23.3)]
        [InlineData(65.9, -23, 0)]
        public void TestValuesofPropertiesTime_Car(double speed, double time, double expTime)
        {
            Car car1 = new Car(speed, time);
            var resultTimeWay = car1.TimeWay;
            car1.Go();
            car1.Stop();
            Assert.Equal(expTime, resultTimeWay);
        }

        [Fact]
        public void TestOfZeroGetInfo_Car()
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
        public void TestPositiveWtihZeroGetInfo_Car01()
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
        public void TestPositiveWtihZeroGetInfo_Car02()
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
        public void TestPositiveValues_Car()
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
        public void TestNegativeValues_Car()
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

        [Theory]
        [InlineData(-23.3, 0)]
        [InlineData(55.1, 0)]
        public void TestValuesofPropertiesSpeed_Bicycle(double speed, double exp)
        {
            Bicycle bicycle1 = new Bicycle(speed);
            var resultSpeedBeforeStop = bicycle1.Speed;
            bicycle1.Go();
            bicycle1.Stop();
            var resultSpeedAfterStop = bicycle1.Speed;
            Assert.Equal(exp, resultSpeedBeforeStop);
            Assert.Equal(0, resultSpeedAfterStop);
        }

        [Theory]
        [InlineData(23.5, -23, 0)]
        public void TestValuesofPropertiesTime_Bicycle(double speed, double time, double expTime)
        {
            Bicycle bicycle1 = new Bicycle(speed, time);
            var resultTimeWay = bicycle1.TimeWay;
            bicycle1.Go();
            bicycle1.Stop();
            Assert.Equal(expTime, resultTimeWay);
        }

        [Fact]
        public void TestOfZeroGetInfo_Bicycle()
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

        [Theory]
        [InlineData(-23.3, 0)]
        [InlineData(412, 0)]
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

        [Theory]
        [InlineData(23.5, -23, 0)]
        public void TestValuesofPropertiesTime_Motocycle(double speed, double time, double expTime)
        {
            Bicycle bicycle1 = new Bicycle(speed, time);
            var resultTimeWay = bicycle1.TimeWay;
            bicycle1.Go();
            bicycle1.Stop();
            Assert.Equal(expTime, resultTimeWay);
        }

        [Fact]
        public void TestOfZeroGetInfo_Motocycle()
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
    }
}