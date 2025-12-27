using System;

namespace CSharpConceptsMvcDemo.Models
{
    public static class DestructorDemo
    {
        public class ResourceHolder
        {
            public void Use()
            {
                // Simulate resource use
            }

            ~ResourceHolder()
            {
                // Finalizer (destructor) — runs non-deterministically
                // Avoid heavy logic here; shown only for demonstration
            }
        }
    }
}
