using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomations.Models
{
    public class EFAlarmRepository : IAlarmRepository
    {
        private AppDbContext context;

        public EFAlarmRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Alarm> Alarms => context.Alarms;

        public void insertAlarm(Alarm alarms)
        {
            if (alarms != null)
            {
                context.Alarms.Add(alarms);
                context.SaveChanges();
            }
            
        }
    }
}
