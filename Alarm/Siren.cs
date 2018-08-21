using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;

namespace Alarm
{
    public  class Siren : ISiren
    {
        public GpioPin SirenPowerGpio { get; set; }
        public GpioPin SirenStartGpio { get; set; }

        public void Trigger(Sensor sensor)
        {
            if (sensor.Status)
            {
                alarm(5000);
                sensor.Status = true;
            }
        }

        public void alarm(int milliseconds)
        {
            try
            {
                SirenPowerGpio.PinMode = GpioPinDriveMode.Output;
                SirenStartGpio.PinMode = GpioPinDriveMode.Output;
                //power up the siren
                SirenPowerGpio.Write(true);
                //start sound/alarm
                SirenStartGpio.Write(true);
                Thread.Sleep(1000);
                SirenStartGpio.Write(false);
                Thread.Sleep(milliseconds);
                //turn off siren
                SirenPowerGpio.Write(false);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred with siren. Error {0}", e);
            }
            
        }
    }
}
