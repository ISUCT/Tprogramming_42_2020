using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestElectronic
    {
        [Theory]
        [InlineData("Acer", "Acer")]
        [InlineData("computer", null)]
        public void TestBrend(string a, string exp)
        {
            Computer actualResult = new Computer(a);
            Assert.Equal(exp, actualResult.Brand);
        }

        [Theory]
        [InlineData("Windows", "Windows")]
        [InlineData("OC", null)]
        public void TestOC(string a, string exp)
        {
            Computer actualResult = new Computer(" ", a);
            Assert.Equal(exp, actualResult.OC);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        [InlineData(8, 8)]
        public void TestRAM(int a, int exp)
        {
            Computer actualResult = new Computer(" ", " ", a);
            Assert.Equal(exp, actualResult.RAM);
        }

        [Theory]
        [InlineData("Acer", "Windows", 64, "Computer:\n  Brand: Acer\n  OC: Windows\n  RAM: 64")]
        [InlineData(" ", " ", -7, "Computer:\n  Brand: \n  OC: \n  RAM: 0")]
        public void TesteEditInf(string a, string b, int c, string exp)
        {
            Computer actualResult = new Computer();
            actualResult.SetInfo(a, b, c);
            Assert.Equal(exp, actualResult.ToString());
        }
    }
}