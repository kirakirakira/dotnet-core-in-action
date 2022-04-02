using Xunit;
using BizDayCalc;
using System;

namespace BizDayCalcTests
{
    public class WeekendRuleTest
    {
        [Fact]
        public void ShouldReturnTrueIfBusinessDayIsNotAWeekend()
        {
            var rule = new WeekendRule();
            Assert.True(rule.CheckIsBusinessDay(new DateTime(2016, 6, 27)));
        }

        [Fact]
        public void ShouldReturnFalseIfBusinessDayIsOnTheWeekend()
        {
            var rule = new WeekendRule();
            Assert.False(rule.CheckIsBusinessDay(new DateTime(2016, 6, 26)));
        }

        [Theory]
        [InlineData(true, "2016-06-27")] // Monday
        [InlineData(true, "2016-03-01")] // Tuesday
        [InlineData(false, "2016-06-26")] // Sunday
        [InlineData(false, "2016-11-12")] // Saturday
        public void IsBusinessDay(bool expected, string date)
        {
            var rule = new WeekendRule();
            Assert.Equal(expected, rule.CheckIsBusinessDay(DateTime.Parse(date)));
        }
    }
}

