using System;
using Xunit;

namespace CourseApp.Tests
{
    public class WeaponTest
    {
        [Theory]
        [InlineData("Name", "Name")]
        [InlineData(" ", " ")]
        public void TestModel(string a, string exp)
        {
            Pistol actualResult = new Pistol(a);
            Assert.Equal(exp, actualResult.Model);
        }

        [Theory]
        [InlineData(9, 9)]
        [InlineData(-9, -9)]
        public void TestCaliber(int a, int exp)
        {
            Pistol actualResult = new Pistol(" ", a);
            Assert.Equal(exp, actualResult.Caliber);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, -1)]
        [InlineData(8, 8)]
        public void TestAge(int a, int exp)
        {
            Pistol actualResult = new Pistol(" ", 0, a);
            Assert.Equal(exp, actualResult.Clip);
        }

        [Theory]
        [InlineData("Name", 9, 5, "model: Name  caliber: 9  Clip: 5")]
        [InlineData( " ", 0, -7, "model:    caliber: 0  Clip: -7")]
        public void TesteEditInf(string n, int b, int a, string exp)
        {
            Pistol actualResult = new Pistol();
            actualResult.EditInf(n, b, a);
            Assert.Equal(exp, actualResult.ToString());
        }
    }
}