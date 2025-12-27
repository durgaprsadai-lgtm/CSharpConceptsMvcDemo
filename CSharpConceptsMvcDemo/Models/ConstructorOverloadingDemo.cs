namespace CSharpConceptsMvcDemo.Models
{
    public static class ConstructorOverloadingDemo
    {
        public class Person
        {
            public string Name;
            public int Age;

            public Person()
            {
                Name = "Unknown";
                Age = 0;
            }

            public Person(string name)
            {
                Name = name;
                Age = 0;
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
