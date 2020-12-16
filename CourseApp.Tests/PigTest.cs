using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PigTest
    {
        [Theory]
        [InlineData("Pig", 5, "Свинья Pig зарезана\nПолучено 5 сала\n")]
        [InlineData("Pig", 0, "Свинья Pig зарезана\nПолучено 0 сала\n")]
        public void TestDiet(string n, int a, string exp)
        {
            Pig actualResult = new Pig(n, 0, a);
            Assert.Equal(exp, actualResult.Died());
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(-2, 0)]
        public void TestAddFat(int a, int exp)
        {
            Pig actualResult = new Pig();
            actualResult.AddFat(a);
            Assert.Equal(exp, actualResult.Fat);
        }

        [Theory]
        [InlineData(5, "Fat: 5\n")]
        [InlineData(-2, "Fat: 0\n")]
        public void TestGetFat(int a, string exp)
        {
            Pig actualResult = new Pig(" ", 0, a);
            Assert.Equal(exp, actualResult.GetFat());
        }

        [Fact]
        public void MakeSound()
        {
            string exp = "Hru-hru\n";
            Pig actualResult = new Pig();
            Assert.Equal(exp, actualResult.MakeSound());
        }
    }
}