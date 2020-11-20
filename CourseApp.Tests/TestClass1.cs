using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestClass1
    {
        [Fact]
        public void ZeroOfPopulation()
        {
            Country country2 = new Country(0, 40, 185);
            var actualResult = country2.Population;
            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void ZeroOfArea()
        {
            Country country2 = new Country(13860, 0, 185);
            var actualResult = country2.Area;
            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void ZeroOfDensity()
        {
            Country country2 = new Country(13860, 40, 0);
            var actualResult = country2.Density;
            Assert.Equal(0, actualResult);
        }
    }
}