using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DuckTest
    {
        [Theory]
        [InlineData("Zhivotnoe", "duck w", 5, "Duck:\nName: Zhivotnoe  Breed: duck w  Age: 5")]
        [InlineData(" ", " ", -7, "Duck:\nName: Неизвестно  Breed: Неизвестна  Age: 0")]
        public void TestDisplayInf(string n, string b, int a, string exp)
        {
            Duck actualResult = new Duck(n, b, a);
            Assert.Equal(exp, actualResult.ToString());
        }

        [Fact]
        public void TestVois()
        {
            string exp = "*Кря*\n";
            Duck actualResult = new Duck();
            Assert.Equal(exp, actualResult.Vois());
        }

        [Fact]
        public void TestMove()
        {
            string exp = "*Полёт*\n";
            Duck actualResult = new Duck();
            Assert.Equal(exp, actualResult.Move());
        }
    }
}