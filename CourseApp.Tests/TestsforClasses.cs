using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestsforClasses
    {
        [Fact]
        public void TestStopPlane()
        {
            Plane testplane = new Plane("IL-2", 300, 5, 6);
            var actualResult = testplane.StopPlane();
            Assert.Equal($"Самолёт IL-2 остановлен\n", actualResult);
        }
    }
}