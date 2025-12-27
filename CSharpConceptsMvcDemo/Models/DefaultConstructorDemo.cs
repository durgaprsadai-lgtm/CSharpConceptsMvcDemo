namespace CSharpConceptsMvcDemo.Models
{
    public static class DefaultConstructorDemo
    {
        public class Car
        {
            public string Brand;
            public int Year;

            public Car()
            {
                Brand = "Unknown";
                Year = 2000;
            }
        }
    }
}
