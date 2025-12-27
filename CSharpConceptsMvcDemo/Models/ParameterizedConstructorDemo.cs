namespace CSharpConceptsMvcDemo.Models
{
    public static class ParameterizedConstructorDemo
    {
        public class Student
        {
            public string Name;
            public int RollNumber;

            public Student(string name, int rollNumber)
            {
                Name = name;
                RollNumber = rollNumber;
            }
        }
    }
}
