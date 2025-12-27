using Microsoft.AspNetCore.Mvc;
using CSharpConceptsMvcDemo.Models;

namespace CSharpConceptsMvcDemo.Controllers
{
    public class MethodsController : Controller
    {
        public IActionResult Index()
        {
            var methodExamples = new MethodExamples();

            ViewBag.FunctionResult = MethodExamples.FunctionExample();
            ViewBag.MethodResult = methodExamples.MethodExample();

            ViewBag.ParameterLessMessage = methodExamples.ParameterLessMessage();

            ViewBag.InstanceAdd = methodExamples.Add(7, 5);
            ViewBag.StaticMultiply = MethodExamples.Multiply(4, 6);

            ViewBag.VoidOutput = methodExamples.VoidPrint("Durga");
            ViewBag.NonVoidOutput = methodExamples.NonVoidConcat("Hello", "World");

            ViewBag.InstanceCall = methodExamples.InstanceScreen(99);
            ViewBag.StaticCall = MethodExamples.StaticDisplay(123);

            return View();
        }
    }
}
