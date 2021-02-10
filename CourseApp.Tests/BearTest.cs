using System;
using Xunit;

namespace CourseApp.Tests
{
    public class BearTest
    {
        [Theory]
        [InlineData("Bear", 5, "Медведь Bear убит\nПолучено 5 сала\n")]
        [InlineData("Bear", 0, "Медведь Bear убит\nПолучено 0 сала\n")]
        public void TestDiet(string n, int a, string exp)
        {
            Bear actualResult = new Bear(n, 0, a);
            Assert.Equal(exp, actualResult.Died());
        }

        [Fact]
        public void TestMakeSound()
        {
            string exp = "*Рык*\n";
            Bear actualResult = new Bear();
            Assert.Equal(exp, actualResult.MakeSound());
        }
    }
}