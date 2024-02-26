using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Settimana_17_Esercizio_1.Models;

namespace Settimana_17_Esercizio_1.Controllers
{
    public class PagamentiController : Controller
    {
        // GET: Pagamenti
        public ActionResult Index()
        {
            List<Pagamenti> listaPagamenti = new List<Pagamenti>();
            listaPagamenti.Add(new Pagamenti("Dicembre 2023", 1200, 'S'));
            listaPagamenti.Add(new Pagamenti("Gennaio 2024", 1200, 'S'));
            listaPagamenti.Add(new Pagamenti("Febbraio 2024", 700, 'A'));

            return View(listaPagamenti);
        }
    }
}
