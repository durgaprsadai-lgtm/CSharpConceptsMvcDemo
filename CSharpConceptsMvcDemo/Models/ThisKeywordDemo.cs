using System;

namespace CSharpConceptsMvcDemo.Models
{
    public static class ThisKeywordDemo
    {
        public class User
        {
            public string name, location;
            public long marks = 470;

            public User(string name, string location)
            {
                this.name = name;
                this.location = location;
            }

            public string GetUserDetails()
            {
                return $"Name: {name}, Location: {location}";
            }
        }

        public static class Exams
        {
            public static string GetDetails(User u)
            {
                double percentage = ((double)u.marks / 600) * 100;
                return $"{u.GetUserDetails()}, Marks: {u.marks}, Percentage: {percentage:0.00}%";
            }
        }
    }
}
