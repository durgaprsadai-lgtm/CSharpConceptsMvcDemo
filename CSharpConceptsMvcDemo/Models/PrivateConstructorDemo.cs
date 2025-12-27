using System;

namespace CSharpConceptsMvcDemo.Models
{
    public static class PrivateConstructorDemo
    {
        public class Logger
        {
            private static Logger? instance;
            private Logger()
            {
                // Simulate initialization
            }

            public static Logger GetInstance()
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }

            public string Log(string message)
            {
                return $"Log: {message}";
            }
        }
    }
}
