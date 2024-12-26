using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensior
{
    internal class Display
    {

        public void Subscribe(Broker broker)
        {
            broker.Subscribe("TemperatureChange", ShowTemp);
        }
        public void ShowTemp(TempArgs T)
        {
            Console.WriteLine($"\n\t\tTemperature Changed To {T.Temp} Degree\n");
        }
    }
}
