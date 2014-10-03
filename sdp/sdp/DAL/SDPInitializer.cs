using SDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDP.DAL
{
    public class SDPInitializer : System.Data.Entity.DropCreateDatabaseAlways<SDPContext>
    {
        protected override void Seed(SDPContext context)
        {
            var events = new List<Event>
            {
                new Event{ Name="UTS Open Day", Body="This is UTS open day", Date="2014-09-06", Image="openday.png", Venue="UTS City Campus, Kuring-gai Campus"},
                new Event{ Name="BiG", Body="BiG group meeting", Date="2014-10-20", Image="BiG.png", Venue="UTS City Campus"},
                new Event{ Name="HSC in the Holidays Workshop", Body="this is some info", Date="2014-09-25", Image="HSCWorkshop.png", Venue="UTS City Campus"},
                new Event{ Name="U@Uni Inspiring Science Teaching", Body="information session on inspiring science teaching", Date="2015-01-20", Image="U@Uni.png", Venue="UTS City Campus"},
                new Event{ Name="UTS Info Day", Body="UTS annual information day for future students", Date="2015-01-06", Image="info_day.png", Venue="UTS City Campus"}
            };

            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();
        }
    }
}