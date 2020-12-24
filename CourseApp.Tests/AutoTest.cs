using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AutoTest
    {
         [Fact]
        public void SpeedEqualZero()
        {
            Auto auto = new Auto(20, 0, 20);
            var actualResult = auto.Speed;
            Assert.Equal(0, actualResult);
        }
    }
}