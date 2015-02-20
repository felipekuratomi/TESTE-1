using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENTLOGTESTE
{
    class Program
    {
        static void Main(string[] args)
        {
            string eventLog = "Application";
            string eventSource = "Logging Demo";
            string eventMessage = "Hello asjodhajklsdfopashf";

            if (!EventLog.SourceExists(eventSource))
            {
                EventLog.CreateEventSource(eventSource,eventLog);

            }

                EventLog.WriteEntry(eventSource,eventMessage);
        }
    }
}
