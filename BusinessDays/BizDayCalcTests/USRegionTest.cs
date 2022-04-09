using System;
using BizDayCalc;
using Xunit;

namespace BizDayCalcTests
{
    [Collection("US region collection")]
    public class USRegionTest
    {
        private USRegionFixture fixture;

        public USRegionTest(USRegionFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData("2016-01-01")]
        [InlineData("2016-12-25")]
        public void TestHolidays(string date)
        {
            Assert.False(fixture.Calc.IsBusinessDay(DateTime.Parse(date)));
        }

        [Theory]
        [InlineData("2016-02-29")]
        [InlineData("2016-01-04")]
        public void TestNonHolidays(string date)
        {
            Assert.True(fixture.Calc.IsBusinessDay(DateTime.Parse(date)));
        }
    }
}
