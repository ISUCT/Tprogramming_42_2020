using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Theory]
        [InlineData("egor", 2001, 9, 3, "Возраст egor: 19 лет, 2 месяцев, 21 дней")]
        [InlineData("max", 2001, 12, 6, "Возраст max: 18 лет, 11 месяцев, 18 дней")]
        [InlineData("andrey", 2020, 11, 24, "Возраст andrey: 0 лет, 0 месяцев, 0 дней")]
        [InlineData("sanya", 2020, 12, 24, "Возраст sanya: введён не верно")]
        public void TestAgeCalc(string actname, int year, int month, int day, string exp)
        {
            Person man = new Person();
            man.Name = actname;
            DateTime manbirth = new DateTime(year, month, day);
            var result = Program.CalcAge(manbirth, man.Name);
            Assert.Equal(exp, result);
        }
    }
}