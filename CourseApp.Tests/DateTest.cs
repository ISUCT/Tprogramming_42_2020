using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DateTest
    {
        [Theory]
        [InlineData(1999, 8, 19, 21, 1, 24)]
        [InlineData(2000, 1, 1, 20, 9, 11)]
        [InlineData(2018, 5, 5, 2, 5, 7)]
        [InlineData(2000, 8, 18, 20, 1, 25)]
        public void TestAge(int y, int m, int d, int expY, int expM, int expD)
        {
            DateTime brithday = new DateTime(y, m, d);
            DateTime date = new DateTime(2020, 10, 12);
            string exp = $"Age: Year:{expY} Month:{expM} Day:{expD}";
            var res = Program.Age(brithday, date);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestDatesEqual()
        {
            DateTime brithday = new DateTime(2020, 10, 12);
            DateTime date = new DateTime(2020, 10, 12);
            string exp = "Даты совпадают";
            var res = Program.Age(brithday, date);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestBrithdayLatelyToday()
        {
            DateTime brithday = new DateTime(2022, 1, 1);
            DateTime date = new DateTime(2020, 10, 12);
            string exp = "Дата еще не наступила";
            var res = Program.Age(brithday, date);
            Assert.Equal(exp, res);
        }
    }
}