using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AnimalTest
    {
        [Theory]
        [InlineData("Animal_1", "Animal_1")]
        [InlineData(" ", "Неизвестно")]
        public void TestName(string a, string exp)
        {
            Dog actualResult = new Dog(a);
            Assert.Equal(exp, actualResult.Name);
        }

        [Theory]
        [InlineData("Breed_1", "Breed_1")]
        [InlineData(" ", "Неизвестна")]
        public void TestBreed(string a, string exp)
        {
            Dog actualResult = new Dog(" ", a);
            Assert.Equal(exp, actualResult.Breed);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        [InlineData(8, 8)]
        public void TestAge(int a, int exp)
        {
            Dog actualResult = new Dog(" ", " ", a);
            Assert.Equal(exp, actualResult.Age);
        }

        [Theory]
        [InlineData("Animal_1", "Breed_1", 5, "Cat:\nName: Animal_1  Breed: Breed_1  Age: 5")]
        [InlineData(" ", " ", -7, "Cat:\nName: Неизвестно  Breed: Неизвестна  Age: 0")]
        public void TesteEditInf(string n, string b, int a, string exp)
        {
            Cat actualResult = new Cat();
            actualResult.EditInf(n, b, a);
            Assert.Equal(exp, actualResult.ToString());
        }
    }
}