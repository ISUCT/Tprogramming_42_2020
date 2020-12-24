using System;
using Xunit;

namespace CourseApp.Tests
{
    public class ZhivotnoeTest
    {
        [Theory]
        [InlineData("Zhivotnoe", "Zhivotnoe")]
        [InlineData(" ", "Неизвестно")]
        public void TestName(string a, string exp)
        {
            Duck actualResult = new Duck(a);
            Assert.Equal(exp, actualResult.Name);
        }

        [Theory]
        [InlineData("duck w", "duck w")]
        [InlineData(" ", "Неизвестна")]
        public void TestBreed(string a, string exp)
        {
            Duck actualResult = new Duck(" ", a);
            Assert.Equal(exp, actualResult.Breed);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        [InlineData(8, 8)]
        public void TestAge(int a, int exp)
        {
            Duck actualResult = new Duck(" ", " ", a);
            Assert.Equal(exp, actualResult.Age);
        }

        [Theory]
        [InlineData("Zhivotnoe", "duck w", 5, "Duck:\nName: Zhivotnoe  Breed: duck w  Age: 5")]
        [InlineData(" ", " ", -7, "Duck:\nName: Неизвестно  Breed: Неизвестна  Age: 0")]
        public void TesteEditInf(string n, string b, int a, string exp)
        {
            Duck actualResult = new Duck();
            actualResult.EditInf(n, b, a);
            Assert.Equal(exp, actualResult.ToString());
        }
    }
}