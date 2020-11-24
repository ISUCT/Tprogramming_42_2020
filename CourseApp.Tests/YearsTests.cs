using System;
using Xunit;

namespace CourseApp.Testsd
{
    public class YearsTests
    {
        [Fact]
        public void TestBeforeTheDate ()
        {
            string exp = "Max: 16 лет, 7 месяцев и 1 дней.";
            Student person = new Student();
             person.Name = "Max";
             DateTime pers = new DateTime(2004, 04, 23);
             var ageP = Program.CalcAge(pers, person.Name);
             Assert.Equal(ageP, exp);
        }

        [Fact]
        public void TestTodayTheDate ()
        {
            string exp = "Max: 0 лет, С днём рождения!";
            Student person = new Student();
             person.Name = "Max";
             DateTime pers = new DateTime(1258, 11, 12);
             pers = DateTime.Today;
             var ageP = Program.CalcAge(pers, person.Name);
             Assert.Equal(ageP, exp);
        }

        [Fact]
        public void TestAfterTheDate ()
        {
            string exp = "Max: 18 лет, 11 месяцев и 18 дней.";
            Student person = new Student();
             person.Name = "Max";
             DateTime pers = new DateTime(2001, 12, 06);
             var ageP = Program.CalcAge(pers, person.Name);
             Assert.Equal(ageP, exp);
        }

        [Fact]
        public void TestNotVornTheDate ()
        {
            string exp = "Max: Еще не родился";
            Student person = new Student();
             person.Name = "Max";
             DateTime pers = new DateTime(2077, 01, 01);
             var ageP = Program.CalcAge(pers, person.Name);
             Assert.Equal(ageP, exp);
        }
    }
}