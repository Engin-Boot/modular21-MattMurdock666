using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}