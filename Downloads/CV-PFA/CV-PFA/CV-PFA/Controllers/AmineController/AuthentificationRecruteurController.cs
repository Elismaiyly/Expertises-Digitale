using Microsoft.AspNetCore.Mvc;
using CV_PFA.Models;

namespace CV_PFA.Controllers.AmineController
{
    public class AuthentificationRecruteurController : Controller
    {

        [HttpGet]
        public IActionResult RegisterRecruteur()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterRecruteur(AuthentificationRecruteur model)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("RegisterRecruteur", "");
            }


            return View(model);
        }

        public IActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}
