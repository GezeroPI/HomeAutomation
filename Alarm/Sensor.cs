using System;
using System.Collections.Generic;
using System.Text;
using Unosquare.RaspberryIO.Gpio;

namespace Alarm
{
    public class Sensor
    {
        private bool _status;
        private List<ISiren> _sirens = new List<ISiren>();
        public string NameLocation { get; set; }
        public GpioPin Data { get; set; }

        public Sensor()
        {
            _status = false;
        }
       
        public void Attach(ISiren restaurant)
        {
            _sirens.Add(restaurant);
        }

        public void Detach(ISiren restaurant)
        {
            _sirens.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (ISiren siren in _sirens)
            {
                siren.Trigger(this);
            }

            Console.WriteLine("");
        }

        public bool Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    Notify(); //Automatically notify our observers of price changes
                }
            }
        }
    }
}
