using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensior
{
    internal class Broker
    {
        Dictionary<string, List<Action<TempArgs>>>_SubList=new();
        public void Subscribe(string subject, Action<TempArgs> temp)
        {
            if(!_SubList.ContainsKey(subject))
            {
                _SubList[subject]=new List<Action<TempArgs>>();
            }
            _SubList[subject].Add(temp);
        }
        public void Publish(string subject, TempArgs temp)
        {
            List<Action<TempArgs>> _SubTemp=_SubList[subject];
            foreach(var _subTemp in _SubTemp)
            {
                _subTemp.Invoke(temp);
            }
        }
    }
}
