using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DHT22Sensor;
using HomeAutomations.Models;
using Microsoft.AspNetCore.Mvc;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;

namespace HomeAutomations.Controllers
{
    [Route("api/[controller]")]
    public class SaveRecordsController : Controller
    {
        private IAlarmRepository _alarmRepository;
        private IConditionRepository _conditionRepository;
        
        public SaveRecordsController(IAlarmRepository alarm, IConditionRepository condition)
        {
            _alarmRepository = alarm;
            _conditionRepository = condition;
        }

        // GET api/SaveRecords
        [HttpGet]
        public IActionResult Get()
        {
            var dhtLocalLivingRoom = new DHT(Pi.Gpio[P1.Gpio17], DHTSensorTypes.DHT11);
            var sensorData = dhtLocalLivingRoom.ReadData();
            var lvRoomSensor1 = new Condition
            {
                SensorName = "LivingRoom1",
                Temperature = sensorData.TempCelcius,
                Humidity = sensorData.Humidity,
                TimeStamp = DateTime.Now
            };
            _conditionRepository.insertCondition(lvRoomSensor1);


            return Ok(StatusCode(200));
        }
        // GET api/SaveRecords/triggered/message/livingPIR
        [HttpGet("{status}/{message}/{sensor}")]
        public IActionResult Get(string status, string message, string sensor)
        {
            var alarmEvent = new Alarm
            {
                Status = status,
                Message = message,
                SensorTriggered = sensor,
                Timestamp = DateTime.Now
            };
            _alarmRepository.insertAlarm(alarmEvent);

            return Ok(StatusCode(200));
        }
    }
}