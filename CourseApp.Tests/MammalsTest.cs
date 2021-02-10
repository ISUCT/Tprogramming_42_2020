using System;
using Xunit;

namespace CourseApp.Tests
{
    public class MammalsTest
    {
        [Theory]
        [InlineData("Mammals", "Mammals")]
        [InlineData("Pig", "Pig")]
        public void TestName(string a, string exp)
        {
            Pig actualResult = new Pig(a, 1);
            Assert.Equal(exp, actualResult.Name);
        }

        [Theory]
        [InlineData(88, 88)]
        [InlineData(-20, 0)]
        public void TestWeight(int a, int exp)
        {
            Pig actualResult = new Pig(" ", a);
            Assert.Equal(exp, actualResult.Weight);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        [InlineData(88, 88)]
        public void TestFat(int a, int exp)
        {
            Pig actualResult = new Pig(" ", 0, a);
            Assert.Equal(exp, actualResult.Fat);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        [InlineData(8, 8)]
        public void TestAge(int a, int exp)
        {
            Pig actualResult = new Pig(" ", 0, a, 88);
            Assert.Equal(exp, actualResult.Age);
        }

        [Theory]
        [InlineData("Pig", 5, "Из Pig можно получить 5 сала\n")]
        [InlineData("Pig", 0, "Pig Беез сала\n")]
        public void TestToString(string n, int a, string exp)
        {
            Bear actualResult = new Bear(n, 8, a);
            Assert.Equal(exp, actualResult.ToString());
        }
    }
}