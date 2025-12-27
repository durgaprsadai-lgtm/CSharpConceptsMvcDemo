using Microsoft.AspNetCore.Mvc;
using CSharpConceptsMvcDemo.Models;

namespace CSharpConceptsMvcDemo.Controllers
{
    public class ParametersController : Controller
    {
        public IActionResult Index()
        {
            int a = 5;
            int originalA = a;

            string callByValueInside, callByValueAfter;
            string callByRefInside, callByRefAfter;
            string callByOutInside, callByOutAfter;

            // Call by value
            ParameterPassingDemo.CallByValue(a, out int aValueResult);
            callByValueInside = $"Inside CallByValue: {aValueResult}";
            callByValueAfter = $"After CallByValue: {a} (unchanged from original {originalA})";

            // Call by ref
            ParameterPassingDemo.CallByRef(ref a, out int aRefResult);
            callByRefInside = $"Inside CallByRef: {aRefResult}";
            callByRefAfter = $"After CallByRef: {a} (changed)";

            // Call by out
            ParameterPassingDemo.CallByOut(out int b, out int bOutResult);
            callByOutInside = $"Inside CallByOut: {bOutResult}";
            callByOutAfter = $"After CallByOut: {b} (assigned inside method)";

            ViewBag.CallByValueInside = callByValueInside;
            ViewBag.CallByValueAfter = callByValueAfter;

            ViewBag.CallByRefInside = callByRefInside;
            ViewBag.CallByRefAfter = callByRefAfter;

            ViewBag.CallByOutInside = callByOutInside;
            ViewBag.CallByOutAfter = callByOutAfter;

            // this keyword demo
            var user = new ThisKeywordDemo.User("Suresh Dasari", "Hyderabad");
            string userDetails = ThisKeywordDemo.Exams.GetDetails(user);
            ViewBag.ThisKeywordResult = userDetails;

            return View();
        }
    }
}
