using System;

namespace CSharpConceptsMvcDemo.Models
{
    public static class StaticConstructorDemo
    {
        public class Configuration
        {
            public static string AppName;
            public static int Version;

            static Configuration()
            {
                AppName = "MyApp";
                Version = 1;
            }
        }
    }
}
