using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;
using DHT22Sensor;
using HomeAutomations.Models;

namespace HomeAutomations.Controllers
{
    [Route("api/[controller]")]
    public class LivingRoomController : Controller
    {
        // GET api/LivingRoom
        [HttpGet]
        public AreaSensor Get()
        {
            //DHT11 sensor initialize at GPIO 17
            var dhtLocalLivingRoom = new DHT(Pi.Gpio[P1.Gpio17], DHTSensorTypes.DHT11);
            var sensorData = dhtLocalLivingRoom.ReadData();
            return new AreaSensor { Name = "LivingRoom1", Temperature = sensorData.TempCelcius.ToString(), Humidity = sensorData.Humidity.ToString() };
        }

        // GET api/LivingRoom/fan/1
        [HttpGet("{device}/{onOff}")]
        public string Get(string device, bool onOff)
        {
            if (device == "fan")
            {
                var fanPin = Pi.Gpio[P1.Gpio26];
                fanPin.PinMode = GpioPinDriveMode.Output;
                fanPin.Write(onOff);
                return $"Fan with Pin No{fanPin.BcmPinNumber} set to {onOff}";
            }
            else if (device == "led")
            {
                var ledPin = Pi.Gpio[P1.Gpio25];
                ledPin.PinMode = GpioPinDriveMode.Output;
                ledPin.Write(onOff);
                return $"Led with Pin No{ledPin.BcmPinNumber} set to {onOff}";
            }
            else
            {
                return "No device selected!";
            }
        }
    }
}
