using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using financasPessoais.Models;

namespace financasPessoais.Controllers
{
    public class HomeController : Controller
    {
        despesasRepositorio despRepositorio = new despesasRepositorio();
        // GET: Home
        public ActionResult Index()
        {
            
            
            return View(despesasRepositorio.lstDespesas);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(despesas pDespesa)
        {
            despRepositorio.Create(pDespesa);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int pId)
        {
            despRepositorio.Delete(pId);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int pId)
        {
            var desp = despesasRepositorio.lstDespesas.Find(x => x.id == pId);
            return View(desp);
        }

        [HttpPost]
        public ActionResult Update(despesas pDespesa)
        {
            despRepositorio.Update(pDespesa);
            return RedirectToAction("Index");
        }
    }
}