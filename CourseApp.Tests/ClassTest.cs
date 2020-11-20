using System;
using Xunit;

namespace CourseApp.Tests
{
    public class ClassTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(-500, 1)]
        [InlineData(12, 12)]
        public void TestStudentAge(int a, int exp)
        {
             Student person = new Student();
             person.Age = a;
             Assert.Equal(person.Age, exp);
        }

        [Theory]
        [InlineData("Sanguine",  "Sanguine")]
        [InlineData("Phlegmatic", "Phlegmatic")]
        [InlineData("Choleric", "Choleric")]
        [InlineData("Melancholic", "Melancholic")]
        [InlineData("Zoomer", "Not defined")]
        [InlineData("Boomer", "Not defined")]
        public void TestTemperament(string a, string exp)
        {
             Student person = new Student();
             person.Temperament = a;
             Assert.Equal(person.Temperament, exp);
        }
    }
}