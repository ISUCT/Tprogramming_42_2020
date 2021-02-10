using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DogTest
    {
        [Theory]
        [InlineData("Animal_1", "Breed_1", 5, "Dog:\nName: Animal_1  Breed: Breed_1  Age: 5")]
        [InlineData(" ", " ", -7, "Dog:\nName: Неизвестно  Breed: Неизвестна  Age: 0")]
        public void TestDisplayInf(string n, string b, int a, string exp)
        {
            Dog actualResult = new Dog(n, b, a);
            Assert.Equal(exp, actualResult.ToString());
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(-2, 0)]
        public void TestEditAge(int a, int exp)
        {
            Dog actualResult = new Dog();
            actualResult.EditAge(a);
            Assert.Equal(exp, actualResult.Age);
        }

        [Theory]
        [InlineData(5, "Age: 5\n")]
        [InlineData(-2, "Age: 0\n")]
        public void TestGetAge(int a, string exp)
        {
            Dog actualResult = new Dog(" ", " ", a);
            Assert.Equal(exp, actualResult.GetAge());
        }

        [Fact]
        public void TestVois()
        {
            string exp = "*Гав*\n";
            Dog actualResult = new Dog();
            Assert.Equal(exp, actualResult.Vois());
        }
    }
}