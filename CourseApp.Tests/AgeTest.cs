using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Theory]
        [InlineData("egor", 2001, 9, 3, 2020, 12, 4, "Возраст egor: 19 лет, 3 месяцев, 2 дней")]
        [InlineData("max", 2001, 12, 6, 2020, 12, 4, "Возраст max: 18 лет, 11 месяцев, 30 дней")]
        [InlineData("andrey", 2020, 12, 4, 2020, 12, 4, "Возраст andrey: 0 лет, 0 месяцев, 0 дней")]
        [InlineData("sanya", 2020, 12, 24, 2020, 12, 4, "Возраст sanya: введён не верно")]
        public void TestAgeCalc(string actname, int yearbirth, int monthbirth, int daybirth, int yeartoday, int monthtoday, int daytoday, string exp)
        {
            Person man = new Person();
            man.Name = actname;
            DateTime manbirth = new DateTime(yearbirth, monthbirth, daybirth);
            DateTime todaydate = new DateTime(yeartoday, monthtoday, daytoday);
            var result = Program.CalcAge(manbirth, todaydate, man.Name);
            Assert.Equal(exp, result);
        }
    }
}