using System;
using Xunit;

namespace CourseApp.Tests
{
    public class RabbitTest
    {
        [Theory]
        [InlineData("Zhivotnoe", "Rabbit b", 5, "Rabbit:\nName: Zhivotnoe  Breed: Rabbit b  Age: 5")]
        [InlineData(" ", " ", -7, "Rabbit:\nName: Неизвестно  Breed: Неизвестна  Age: 0")]
        public void TestDisplayInf(string n, string b, int a, string exp)
        {
            Rabbit actualResult = new Rabbit(n, b, a);
            Assert.Equal(exp, actualResult.ToString());
        }

        [Fact]
        public void TestVois()
        {
            string exp = "*Ф ы р*\n";
            Rabbit actualResult = new Rabbit();
            Assert.Equal(exp, actualResult.Vois());
        }

        [Fact]
        public void TestMove()
        {
            string exp = "Прыг\n";
            Rabbit actualResult = new Rabbit();
            Assert.Equal(exp, actualResult.Move());
        }
    }
}