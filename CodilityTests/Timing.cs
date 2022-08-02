using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CodilityTests
{
    public class Timing
    {
        TimeSpan startTime;
        TimeSpan duration;

        public Timing()
        {
            startTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public void StopTime()
        {
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startTime);
               
        }

        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }

        public TimeSpan ResultDur()
        {
            return duration;
        }


    }
}
