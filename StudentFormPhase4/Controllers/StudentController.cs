using Microsoft.AspNetCore.Mvc;
using StudentFormPhase4.Models;

namespace StudentFormPhase4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student model)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Submitted", model);
            }
            else
            {

                return View(model);
            }
        }

        public ActionResult Submitted(Student model)
        {
            return View(model);
        }

    
}
}
