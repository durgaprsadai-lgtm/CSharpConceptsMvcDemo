namespace CSharpConceptsMvcDemo.Models
{
    public static class ParameterPassingDemo
    {
        // Call by value - a copy is passed
        public static void CallByValue(int x, out int insideValue)
        {
            x = x + 10;
            insideValue = x;
        }

        // Call by reference - original variable can be modified
        public static void CallByRef(ref int x, out int insideValue)
        {
            x = x + 10;
            insideValue = x;
        }

        // Call by out - must be assigned inside the method before returning
        public static void CallByOut(out int x, out int insideValue)
        {
            x = 20;
            insideValue = x;
        }
    }
}
