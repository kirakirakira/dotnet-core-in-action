using Xunit;
using BizDayCalc;
using System;
using System.Collections.Generic;

namespace BizDayCalcTests
{
    public class WeekendRuleTest
    {
        public static IEnumerable<object[]> Days
        {
            get
            {
                yield return new object[] { true, new DateTime(2016, 6, 27) };
                yield return new object[] { true, new DateTime(2016, 3, 1) };
                yield return new object[] { false, new DateTime(2016, 6, 26) };
                yield return new object[] { false, new DateTime(2016, 11, 12) };
            }
        }
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
        [MemberData(nameof(Days))]
        public void IsBusinessDay(bool expected, string date)
        {
            var rule = new WeekendRule();
            Assert.Equal(expected, rule.CheckIsBusinessDay(DateTime.Parse(date)));
        }
    }
}

