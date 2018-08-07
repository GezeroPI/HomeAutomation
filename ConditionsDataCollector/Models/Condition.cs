using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConditionsDataCollector.Models
{
    class Condition
    {
        [Key]
        public int Id { get; set; }
        public string SensorName { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
