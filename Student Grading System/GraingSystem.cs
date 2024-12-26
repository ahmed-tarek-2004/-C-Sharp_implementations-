using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class GraingSystem
    {
        public void displayGradingInfo(List<Student>Students,
            Func<List<int>,double>Getavg,
            Predicate<double>ifPassed,
            Action<Student,double,bool>display)
        {
            double avg = 0;
            bool Passed = true;
            for (int i = 0; i < Students?.Count; i++)
            {
                avg = Getavg(Students[i].grades);
                Passed = ifPassed(avg);
                display(Students[i],avg,Passed);
            }
        }
    }
}
