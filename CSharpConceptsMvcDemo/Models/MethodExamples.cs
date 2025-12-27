using System;

namespace CSharpConceptsMvcDemo.Models
{
    public class MethodExamples
    {
        // Function-like (static)
        public static string FunctionExample() => "This is a function (static method in C#).";

        // Method (instance)
        public string MethodExample() => "This is an instance method.";

        // Parameter-less method
        public string ParameterLessMessage()
        {
            return "Hello World! (Parameter-less method)";
        }

        // Parameterized methods
        public int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        // Void method
        public string VoidPrint(string name)
        {
            // Typically void prints to console; here we return string for UI
            return $"Welcome back to {name}";
        }

        // Non-void method
        public string NonVoidConcat(string a, string b)
        {
            return $"{a} {b}";
        }

        // Instance vs static
        public string InstanceScreen(int greet)
        {
            return $"Instance Screen called with {greet}";
        }

        public static string StaticDisplay(int number)
        {
            return $"Static Display called with {number}";
        }
    }
}
