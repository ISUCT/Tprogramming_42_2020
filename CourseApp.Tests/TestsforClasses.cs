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
            var actualResult = testplane.Stop();
            Assert.Equal(0, actualResult);
        }

        [Theory]
        [InlineData("Plane", 11, 10, 0, true)]
        [InlineData("AN-12", 10, 12, 500, false)]
        [InlineData("NicePlane", 10, 10, 200, false)]
        public void TestPlaces(string name, int places, int passengers, int speed, bool exp)
        {
            Plane testplane = new Plane(name, places, passengers, speed);
            var res = testplane.IsPlaces();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestUndifinedForPlaces()
        {
            Plane bigplane = new Plane();
            var res = bigplane.IsPlaces();
            var exp = false;
            Assert.Equal(exp, res);
        }

        [Theory]
        [InlineData("Airobus", 200, "Я самолёт\n")]
        [InlineData("IL-6", 20, "Я самолёт\n")]
        public void TestMakeSoundPlane(string name, int places, string exp)
        {
            Plane plane1 = new Plane(name, places);
            var resplane = plane1.MakeSound();
            Assert.Equal(resplane, exp);
        }

        [Theory]
        [InlineData("Bmw", 6, "Я машина\n")]
        [InlineData("Mercedes", 5, "Я машина\n")]
        public void TestMakeSoundCar(string name, int places, string exp)
        {
            Car car1 = new Car(name, places);
            var rescar = car1.MakeSound();
            Assert.Equal(rescar, exp);
        }

        [Fact]
        public void TestMakeSoundVehicle()
        {
            Vehicle car = new Car("Audi", 5);
            Vehicle plane = new Plane();
            var rescar = car.MakeSound();
            var resplane = plane.MakeSound();
            var expcar = "Я машина\n";
            var expplane = "Я самолёт\n";
            Assert.Equal(rescar, expcar);
            Assert.Equal(resplane, expplane);
        }
    }
}