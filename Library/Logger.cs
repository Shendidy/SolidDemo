using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Logger : ILogger
    {
        public void ShareMessage(string message)
            => Console.WriteLine(message);
        public string GetInput()
            => Console.ReadLine();
    }
}
