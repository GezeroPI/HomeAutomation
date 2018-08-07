using System;
using System.Collections.Generic;
using System.Text;
using Unosquare.RaspberryIO.Gpio;

namespace Alarm
{
    class PirSensor
    {
        public string NameLocation { get; set; }
        public GpioPin Data { get; set; }


    }
}
