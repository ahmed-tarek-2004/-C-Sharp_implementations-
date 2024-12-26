using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensior
{
    internal class Sensor
    {
        Broker broker;
        public event EventHandler<TempArgs> Link;
        private int currentTemp { get; set; }
        public Sensor(Broker _broker)
        {
            currentTemp = 0;
            broker = _broker;
        }
        public void changeTemp(int Temp)
        {
            currentTemp = Temp;
            broker.Publish("TemperatureChange", new TempArgs(currentTemp));
            //Link.Invoke(this, new TempArgs(currentTemp));
            //Link.Invoke(Temp, new TempArgs(currentTemp));
        }
    }
}
