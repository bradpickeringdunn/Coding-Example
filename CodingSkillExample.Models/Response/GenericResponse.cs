using Backbone.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingSkillExample.Models.Response
{
    public class TimeServiceResponse
    {
        public TimeServiceResponse()
        {
            Notifications = new NotificationCollection();
        }

        public DateTime NextworkingDay{ get; set; }
        public NotificationCollection Notifications { get; set; }
    }
}
