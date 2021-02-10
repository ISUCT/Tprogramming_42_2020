using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestDates
    {
        [Fact]
        public static void TestDateOfBirthLower()
        {
            DateTime today = new DateTime(2020, 12, 20);
            DateTime dateOfBirth = new DateTime(2001, 11, 18);

            int[] res = Program.DatesDifference(dateOfBirth, today);
            int[] expected = { 19, 1, 7 };

            Assert.Equal(expected[0], res[0]);
            Assert.Equal(expected[1], res[1]);
            Assert.Equal(expected[2], res[2]);
        }

        [Fact]
        public static void TestDateOfBirthHigher()
        {
            DateTime today = new DateTime(2020, 12, 20);
            DateTime dateOfBirth = new DateTime(2021, 7, 5);

            int[] res = Program.DatesDifference(dateOfBirth, today);
            int[] expected = { 0, -6, -17 };

            Assert.Equal(expected[0], res[0]);
            Assert.Equal(expected[1], res[1]);
            Assert.Equal(expected[2], res[2]);
        }

        [Fact]
        public static void TestDateOfBirthEqual()
        {
            DateTime today = new DateTime(2020, 12, 20);
            DateTime dateOfBirth = new DateTime(2020, 12, 20);

            int[] res = Program.DatesDifference(dateOfBirth, today);
            int[] expected = { 0, 0, 0 };

            Assert.Equal(expected[0], res[0]);
            Assert.Equal(expected[1], res[1]);
            Assert.Equal(expected[2], res[2]);
        }
    }
}