using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CatTest
    {
        [Theory]
        [InlineData("Animal_1", "Breed_1", 5, "Cat:\nName: Animal_1  Breed: Breed_1  Age: 5")]
        [InlineData(" ", " ", -7, "Cat:\nName: Неизвестно  Breed: Неизвестна  Age: 0")]
        public void TestDisplayInf(string n, string b, int a, string exp)
        {
            Cat actualResult = new Cat(n, b, a);
            Assert.Equal(exp, actualResult.ToString());
        }

        [Fact]
        public void TestVois()
        {
            string exp = "*Мяу*\n";
            Cat actualResult = new Cat();
            Assert.Equal(exp, actualResult.Vois());
        }
    }
}