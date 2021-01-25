using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PistolTest
    {
        [Theory]
        [InlineData( 1, 0)]
        [InlineData( 2, 1)]
        public void Test(int a, int exp)
        {
            Pistol actualResult = new Pistol(" ", 0, a);
            actualResult.Shot();
            Assert.Equal(exp, actualResult.Clip);
        }
    }
}