using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConditionsDataCollector.Models
{
    class Alarm
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string SensorTriggered { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
