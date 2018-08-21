using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm
{
    public interface ISiren
    {
        void Trigger(Sensor sensors);
    }
}
