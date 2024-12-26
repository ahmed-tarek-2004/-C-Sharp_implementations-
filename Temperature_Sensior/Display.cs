using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensior
{
    internal class Display
    {
        public void ShowTemp(object? Event, TempArgs T)
        {
            Console.WriteLine($"\n\t\tTemperature Changed To {T.Temp} Degree\n");
        }
    }
}
