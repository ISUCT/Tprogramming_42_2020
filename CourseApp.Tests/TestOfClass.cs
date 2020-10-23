using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestOfClass
    {
        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0)]
        [InlineData(234, 0, 234, 0, 0, 0)]
        [InlineData(0, 567, 0, 0, 0, 0)]
        [InlineData(0, -244, 0, 0, 0, 0)]
        [InlineData(1232, 2324, 1232, 0, 0, 2863168)]
        [InlineData(1, 3, 1, 0, 0, 3)]
        public void TetsOfGo(int inSpeed, int inTime, int inTurpleBeforeFirst, int inTurpleBeforeSecond, int inTurpleAtferFirst, int inTurpleAfterSecond)
        {
            Car car1 = new Car(inSpeed, inTime);
            Tuple<int, int> resultTurpleFirst = car1.GetInfo();
            var result = car1.Go();
            car1.Stop();
            Tuple<int, int> resultTurpleSecond = car1.GetInfo();
            Assert.Equal(inSpeed, result);
            Assert.Equal(inTurpleBeforeFirst, resultTurpleFirst.Item1);
            Assert.Equal(inTurpleBeforeSecond, resultTurpleFirst.Item2);
            Assert.Equal(inTurpleAtferFirst, resultTurpleSecond.Item1);
            Assert.Equal(inTurpleAfterSecond, resultTurpleSecond.Item2);
        }
    }
}