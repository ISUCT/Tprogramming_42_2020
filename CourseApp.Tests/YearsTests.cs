using System;
using Xunit;

namespace CourseApp.Testsd
{
    public class YearsTests
    {
        [Fact]
        public void TestBeforeTheDate ()
        {
            DateTime today = new DateTime(2020, 12, 08);
            string exp = "Max: 16 лет, 7 месяцев, 17 дней.";
            Student person = new Student();
             person.Name = "Max";
             DateTime pers = new DateTime(2004, 04, 23);
             var ageP = Program.CalcAge(today, pers, person.Name);
             Assert.Equal(ageP, exp);
        }

        [Fact]
        public void TestTodayTheDate ()
        {
            DateTime today = new DateTime(2020, 12, 08);
            string exp = "Max: 0 лет, 0 месяцев, 0 дней.";
            Student person = new Student();
             person.Name = "Max";
             DateTime pers = new DateTime(2020, 12, 08);
             var ageP = Program.CalcAge(today, pers, person.Name);
             Assert.Equal(ageP, exp);
        }

        [Fact]
        public void TestAfterTheDate ()
        {
            DateTime today = new DateTime(2020, 12, 08);
            string exp = "Max: 19 лет, 0 месяцев, 3 дней.";
            Student person = new Student();
             person.Name = "Max";
             DateTime pers = new DateTime(2001, 12, 06);
             var ageP = Program.CalcAge(today, pers, person.Name);
             Assert.Equal(ageP, exp);
        }
    }
}