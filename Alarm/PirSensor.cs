using System;
using System.Collections.Generic;
using System.Text;
using Unosquare.RaspberryIO.Gpio;

namespace Alarm
{
    class PirSensor: Sensor
    {
        public PirSensor(bool status) : base(status) { }
    }
}
