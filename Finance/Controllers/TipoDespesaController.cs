using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finance.Controllers
{
    public class TipoDespesaController : Controller
    {
        // GET: TipoDespesa
        public ActionResult Index()
        {
            return View("Cadastro");
        }
    }
}