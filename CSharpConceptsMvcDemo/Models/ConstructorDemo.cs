namespace CSharpConceptsMvcDemo.Models
{
    public static class ConstructorDemo
    {
        public class Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
