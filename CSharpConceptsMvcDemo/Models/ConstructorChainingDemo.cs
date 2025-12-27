using System;

namespace CSharpConceptsMvcDemo.Models
{
    public static class ConstructorChainingDemo
    {
        public class Animal
        {
            public Animal()
            {
                // Base constructor logic
            }
        }

        public class Dog : Animal
        {
            public Dog() : base()
            {
                // Derived constructor logic
            }
        }
    }
}
