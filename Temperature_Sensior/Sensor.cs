using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensior
{
    internal class Sensor
    {
        public event EventHandler<TempArgs> Link;
        private int currentTemp { get; set; }
        public Sensor()
        {
            currentTemp = 0;
        }
        public void changeTemp(int Temp)
        {
            currentTemp = Temp;
            Link.Invoke(this, new TempArgs(currentTemp));
            //Link.Invoke(Temp, new TempArgs(currentTemp));
        }

    }
}
