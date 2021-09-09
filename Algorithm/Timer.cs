using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Timer
    {
        private readonly DateTime startTime;
        private DateTime endTime;
        public Timer()
        {
            startTime = DateTime.Now;
        }

        public TimeSpan EndTime()
        {
            endTime = DateTime.Now;
            return endTime - startTime;
        }

    }
}
