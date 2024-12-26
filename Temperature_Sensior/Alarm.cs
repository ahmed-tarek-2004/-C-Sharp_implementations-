using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensior
{
    internal class Alarm
    {
        private int alarm { get; set; }
        public Alarm()
        {
            alarm = 52;
        }
        public void ChangeAlarm(int NewAlarm)
        {
            Console.WriteLine($"\n\t\tAlarm Changed From {alarm} To {NewAlarm}\n");
            alarm = NewAlarm;
        }
        public void Fire(object? obj, TempArgs e)
        {
            if (e.Temp > alarm)
                Console.WriteLine($"\n\t\tWarning !! , Temperature Now is More {alarm} Degree\n");
        }
    }
}
