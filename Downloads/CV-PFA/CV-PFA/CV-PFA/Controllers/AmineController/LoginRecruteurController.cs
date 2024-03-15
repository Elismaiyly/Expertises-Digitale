using Microsoft.AspNetCore.Mvc;

namespace CV_PFA.Controllers.AmineController
{
    public class LoginRecruteurController : Controller
    {
        public IActionResult ActionRecruteur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ActionRecruteur(string usename, string password)
        {
            if (usename == "recruteur" && password == "motdepasse")
            {
                return RedirectToAction("ViewRecruteur", "Recruteur");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Nom d'utilisateur ou mot de passe incorrect");
                return View();
            }
        }
    }
}
