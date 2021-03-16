using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_ASP_XSS.Controllers
{
    public class HomeController : Controller
    {
        private static List<string> messages = new List<string>()
        {
            "Hello World",
            "Ceci est une demo"
        };

        [HttpGet]
        public ActionResult Index()
        {
            return View(messages);
        }

        [HttpPost]
        // Le framework protege contre la récéption d'injection de code "Html"
        // ↓ Cet attribut déactive la sécurité.
        [ValidateInput(false)] 
        public ActionResult Index(string nouveauMessage)
        {
            messages.Add(nouveauMessage);

            return View(messages);
        }

    }
}