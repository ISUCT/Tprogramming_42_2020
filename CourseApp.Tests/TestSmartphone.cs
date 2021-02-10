using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestSmartphone
    {
        [Theory]
        [InlineData("Honor", "Android", 64, "Smartphone:\n  Brand: Honor\n  OC: Android\n  RAM: 64")]
        [InlineData(" ", " ", -7, "Smartphone:\n  Brand: \n  OC: \n  RAM: 0")]
        public void TestDisplayInf(string a, string b, int c, string exp)
        {
            Smartphone actualResult = new Smartphone(a, b, c);
            Assert.Equal(exp, actualResult.ToString());
        }

        [Fact]
        public void TestStart()
        {
            string exp = "Включение\n";
            Smartphone actualResult = new Smartphone();
            Assert.Equal(exp, actualResult.Start());
        }
    }
}