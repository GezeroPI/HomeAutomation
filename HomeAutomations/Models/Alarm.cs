using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomations.Models
{
    public class Alarm
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string SensorTriggered { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
