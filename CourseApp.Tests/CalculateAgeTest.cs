using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CalculateAgeTest
    {
        [Theory]
        [InlineData(2001, 10, 31, 2020, 12, 15, "Возраст: 19 лет, 1 месяцев, 15 дней")]
        [InlineData(2005, 12, 15, 2020, 12, 13, "Возраст: 14 лет, 11 месяцев, 30 дней")]
        [InlineData(1995, 12, 15, 2020, 12, 15, "Возраст: 25 лет, 0 месяцев, 1 дней")]
        [InlineData(2020, 12, 15, 2020, 12, 15, "Возраст: 0 лет, 0 месяцев, 0 дней")]
        [InlineData(2077, 12, 24, 2038, 08, 22, "Возраст указан не верно")]
        public void CalcAgeTest(int yearBirth, int monthBirth, int dayBirth, int yearToday, int monthToday, int dayToday, string exp)
        {
            DateTime birthDay = new DateTime(yearBirth, monthBirth, dayBirth);
            DateTime todayDay = new DateTime(yearToday, monthToday, dayToday);
            var result = Program.CalculateAge(birthDay, todayDay);
            Assert.Equal(exp, result);
        }
    }
}