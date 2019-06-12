using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ponto_Digital.Controllers
{
    public class HomeController : Controller 
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
        private const string SESSION_ADM = "_ADM";
          public IActionResult Index () {
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            ViewData["NomeView"] = "Home";

            ViewData["Adm"] = HttpContext.Session.GetString(SESSION_ADM);
            ViewData["NomeView"] = "Home";

            return View ();
        }

        
    }
}