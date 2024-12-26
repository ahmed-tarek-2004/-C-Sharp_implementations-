using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensior
{
    internal class TempArgs:EventArgs
    {
        public int Temp {  get; set; }
        public TempArgs(int temp)
        {
            Temp = temp;
        }
    }
}
