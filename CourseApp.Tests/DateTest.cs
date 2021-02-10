using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DateTest
    {
        [Theory]
        [InlineData(2001, 7, 14, 19, 4, 26)]
        [InlineData(1900, 1, 1, 120, 11, 8)]
        [InlineData(2018, 2, 5, 2, 10, 4)]
        [InlineData(1960, 9, 27, 60, 2, 13)]
        [InlineData(2010, 12, 10, 9, 11, 30)]
        [InlineData(2019, 12, 7, 1, 0, 2)]
        [InlineData(2017, 12, 10, 2, 11, 30)]
        [InlineData(2017, 6, 5, 3, 6, 4)]
        public void TestAge(int y, int m, int d, int expY, int expM, int expD)
        {
            DateTime brithday = new DateTime(y, m, d);
            DateTime date = new DateTime(2020, 12, 9);
            string exp = $"Age: Year:{expY} Month: {expM} Day: {expD}";
            var res = Program.Age(brithday, date);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestDatesEqual()
        {
            DateTime brithday = new DateTime(2020, 12, 9);
            DateTime date = new DateTime(2020, 12, 9);
            string exp = "The dates are equal";
            var res = Program.Age(brithday, date);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestBrithdayLatelyToday()
        {
            DateTime brithday = new DateTime(2020, 12, 10);
            DateTime date = new DateTime(2020, 12, 9);
            string exp = "The date has not come";
            var res = Program.Age(brithday, date);
            Assert.Equal(exp, res);
        }
    }
}