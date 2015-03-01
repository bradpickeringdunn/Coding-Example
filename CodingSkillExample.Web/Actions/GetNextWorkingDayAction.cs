using Backbone.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodingSkillExample.Domain;
using CodingSkillExample.Models;
using CodingSkillExample.Models.Response;
using Backbone.Utilities;
using CodingSkillExample.Web;
using CodingSkillExample.Web.Properties;

namespace CodingSkillExample.Actions
{
    public class GetNextWorkingDayAction<T> where T:class
    {
        private ITimeService TimeService;

        public GetNextWorkingDayAction(ITimeService timeService)
        {
            this.TimeService = timeService;
            Guardian.ArgumentNotNull(timeService, "timeService");
        }

        public Func<WorkingDayViewModel, T> OnComplete { get; set; }

        public T Execute(DateTime? date)
        {
            var model = new WorkingDayViewModel();

            TimeServiceResponse result = new TimeServiceResponse();

            if (!date.HasValue)
            {
                model.Notifications.Add(new Notification(Errors.DateNotValid));
            }

            if (!model.Notifications.HasErrors)
            {
                result = TimeService.ReturnNextWorkingDay(date.Value);
                model.Notifications = result.Notifications;
            };

            if (!model.Notifications.HasErrors)
            {
                model.NextWorkingDay = result.NextworkingDay;
            }
            
            return OnComplete(model);
        }
    }
}