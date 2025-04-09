using System;

namespace AuthenticationService1.Logging
{
    public class Logger
    {
        public void WriteEvent(string eventMessage)
        {
            Console.WriteLine(eventMessage);
        }

        public void WriteError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
