using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSkillExample.Domain.Tests
{
    [TestClass]
    public class TimeServiceTestFixute
    {
        [TestMethod]
        public void TimeService()
        {
            var workingDay = new DateTime(2015,02,27);

            var timeService = new Domain.TimeService();

            var result = timeService.ReturnNextWorkingDay(workingDay);

            Assert.IsTrue(result.NextworkingDay.Date == new DateTime(2015, 12, 27).Date);
        }
    }
}
