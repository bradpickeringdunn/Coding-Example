using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;
using CodingSkillExample.Domain;
using CodingSkillExample.Actions;

namespace CodingSkillExample.Tests
{
    [TestClass]
    public class GetNextWorkingDayActionTextFixture
    {
        [TestMethod]
        public void GetNextWorkingDayAction_Generates_Error_If_Date_Is_Null()
        {
            var timeService = A.Fake<ITimeService>();

            var result = new GetNextWorkingDayAction<dynamic>(timeService)
            {
                OnComplete = (model) => new { Model = model}
            }.Execute(null);

            Assert.IsTrue(result.Model.Notifications.HasErrors);
        }
    }
}
