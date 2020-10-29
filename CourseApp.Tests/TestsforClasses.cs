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

        [Theory]
        [InlineData("Plane", 10, 11, true)]
        [InlineData("AN-12", 12, 10, false)]
        [InlineData("NicePlane", 10, 10, false)]
        public void TestPlaces(string name, int passengers, int places, bool exp)
        {
            Plane testplane = new Plane(name, passengers, places);
            var res = testplane.CheckPlaces();
            Assert.Equal(exp, res);
        }
    }
}