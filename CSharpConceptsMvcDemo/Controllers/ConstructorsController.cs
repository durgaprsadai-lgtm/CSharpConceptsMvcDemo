using Microsoft.AspNetCore.Mvc;
using CSharpConceptsMvcDemo.Models;

namespace CSharpConceptsMvcDemo.Controllers
{
    public class ConstructorsController : Controller
    {
        public IActionResult Index()
        {
            // Base constructor demo
            var person1 = new ConstructorDemo.Person("Alice", 30);
            var person2 = new ConstructorDemo.Person("Bob", 25);

            // Default/Parameterless constructor
            var carDefault = new DefaultConstructorDemo.Car();

            // Parameterized constructor
            var student1 = new ParameterizedConstructorDemo.Student("Farhan", 101);
            var student2 = new ParameterizedConstructorDemo.Student("Nadia", 102);

            // Copy constructor
            var bookOriginal = new CopyConstructorDemo.Book("1984", "George Orwell");
            var bookCopy = new CopyConstructorDemo.Book(bookOriginal);

            // Private constructor with Singleton
            var logger1 = PrivateConstructorDemo.Logger.GetInstance();
            var logger2 = PrivateConstructorDemo.Logger.GetInstance();
            bool sameLoggerInstance = object.ReferenceEquals(logger1, logger2);

            // Static constructor
            string appName = StaticConstructorDemo.Configuration.AppName;
            int version = StaticConstructorDemo.Configuration.Version;

            // Constructor overloading
            var p1 = new ConstructorOverloadingDemo.Person();
            var p2 = new ConstructorOverloadingDemo.Person("Ravi");
            var p3 = new ConstructorOverloadingDemo.Person("Sita", 28);

            // Destructor sample (finalizer) will run non-deterministically; we simulate usage
            var destruct = new DestructorDemo.ResourceHolder();
            destruct.Use();

            // Constructor chaining (base/this)
            var dog = new ConstructorChainingDemo.Dog();

            ViewBag.Person1 = $"{person1.Name}, {person1.Age}";
            ViewBag.Person2 = $"{person2.Name}, {person2.Age}";

            ViewBag.CarDefault = $"{carDefault.Brand}, {carDefault.Year}";
            ViewBag.Student1 = $"{student1.Name}, {student1.RollNumber}";
            ViewBag.Student2 = $"{student2.Name}, {student2.RollNumber}";

            ViewBag.BookOriginal = $"{bookOriginal.Title}, {bookOriginal.Author}";
            ViewBag.BookCopy = $"{bookCopy.Title}, {bookCopy.Author}";

            ViewBag.SameLoggerInstance = sameLoggerInstance;

            ViewBag.StaticConfig = $"{appName} v{version}";

            ViewBag.Overload1 = $"{p1.Name}, {p1.Age}";
            ViewBag.Overload2 = $"{p2.Name}, {p2.Age}";
            ViewBag.Overload3 = $"{p3.Name}, {p3.Age}";

            ViewBag.DogConstructed = "Dog constructed with base Animal call.";

            return View();
        }
    }
}
