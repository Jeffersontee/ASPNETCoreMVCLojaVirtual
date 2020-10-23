using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        /*
         * ActionResult
         * IActionResult      
         */
        public ActionResult Visualizar()
        {
            return View();
            //return new ContentResult() { Content = "<h3>Produto -> Visualizar</h3>", ContentType = "text/html" };
        }

        public string Index()
        {
            return "Produto";
        }

    }
}
