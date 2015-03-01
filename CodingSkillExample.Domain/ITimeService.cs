using CodingSkillExample.Models.Response;
using System;

namespace CodingSkillExample.Domain
{
    public interface ITimeService
    {
        TimeServiceResponse ReturnNextWorkingDay(DateTime today);
    }
}
