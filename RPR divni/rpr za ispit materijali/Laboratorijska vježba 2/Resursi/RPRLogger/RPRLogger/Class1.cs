using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPRLogger
{
    public class Logger
    {
        public enum Severity {
            NORMAL,
            WARNING,
            ERROR
        }

        /// <summary>
        /// User for logging stuff.
        /// </summary>
        /// <param name="severity">How important is this log entry.</param>
        /// <param name="message">Log entry itself.</param>
        public void log(Severity severity, String message)
        {
            Console.WriteLine("RPR Logger at {0}:{1}. Message: {2}", DateTime.Now, severity, message);
        }
    }
}
