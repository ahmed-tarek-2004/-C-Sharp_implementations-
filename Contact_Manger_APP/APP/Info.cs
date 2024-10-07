using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    internal abstract class Info
    {
        protected string Desc;
        protected string Type;

        internal abstract void set();
        internal abstract string get();
        
    }
}
