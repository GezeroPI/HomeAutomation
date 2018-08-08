using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomations.Models
{
    public interface IAlarmRepository
    {
        IQueryable<Alarm> Alarms { get; }
        void insertAlarm(Alarm alarm);
    }
}
