using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestComputer
    {
        [Theory]
        [InlineData("Acer", "Windows", 5, "Computer:\n  Brand: Acer\n  OC: Windows\n  RAM: 5")]
        [InlineData(" ", " ", -7, "Computer:\n  Brand: \n  OC: \n  RAM: 0")]
        public void TestToString(string a, string b, int c, string exp)
        {
            Computer actualResult = new Computer(a, b, c);
            Assert.Equal(exp, actualResult.ToString());
        }

        [Theory]
        [InlineData(64, 64)]
        [InlineData(-7, 0)]
        public void TestSetRAM(int c, int exp)
        {
            Computer actualResult = new Computer();
            actualResult.SetRAM(c);
            Assert.Equal(exp, actualResult.RAM);
        }

        [Theory]
        [InlineData(64, "RAM 64")]
        [InlineData(-7, "RAM 0")]
        public void TestGetRAM(int c, string exp)
        {
            Computer actualResult = new Computer(" ", " ", c);
            Assert.Equal(exp, actualResult.GetRAM());
        }

        [Fact]
        public void TestStart()
        {
            string exp = "Запуск\n";
            Computer actualResult = new Computer();
            Assert.Equal(exp, actualResult.Start());
        }
    }
}