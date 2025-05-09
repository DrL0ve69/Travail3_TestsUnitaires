using Microsoft.AspNetCore.Mvc;
using Travail3_TestsUnitaires.Models;

namespace Travail3_TestsUnitaires.Controllers
{
    public class Exercice2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Bienvenue() 
        {
            return "<h2>Bienvenu dans mon site web</h2>";
        }
        public ContentResult Bienvenue2()
        {
            return Content("<h2>Bienvenu dans mon site web</h2>", "text/html");
        }
        public IActionResult AfficherVue() 
        {
            return View();
            /* Le message d'erreur => exercice2 numéro3
             * InvalidOperationException: The view 'AfficherVue' was not found. The following locations were searched:
               /Views/Exercice2/AfficherVue.cshtml
               /Views/Shared/AfficherVue.cshtml
             */
        }
        public IActionResult AfficherPdf()
        {

            return File("~img/horaire2025.pdf", "application/pdf");
            //new FileStreamResult(new FileStream(@"wwwroot/img/horaire2025.pdf", FileMode.Open, FileAccess.Read), "application/pdf"); /
        }
        public IActionResult AfficherClients() 
        {
            List<Client> listeClients = new List<Client>() 
            {
                new("Chouinard", "Gino", "sonCourriel@fdsf.com",1),
                new("Bond", "James", "sonCourriel@fdsf.com",2),
                new("Lemieux", "Mario", "sonCourriel@fdsf.com",3),
                new("Curry", "Steph", "sonCourriel@fdsf.com",4),
                new("James", "Lebron", "sonCourriel@fdsf.com",5),
            };

            return Json(listeClients);
        }
        public IActionResult Rediriger() 
        {
            return RedirectToAction("Bienvenue");
        }
    }
}
