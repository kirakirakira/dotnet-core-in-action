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
            Console.WriteLine("At least I did something");
            var rule = new WeekendRule();
            Assert.True(rule.CheckIsBusinessDay(new DateTime(2016, 6, 27)));
        }

        [Fact]
        public void ShouldReturnFalseIfBusinessDayIsOnTheWeekend()
        {
            var rule = new WeekendRule();
            Assert.False(rule.CheckIsBusinessDay(new DateTime(2016, 6, 26)));
        }
    }

}

