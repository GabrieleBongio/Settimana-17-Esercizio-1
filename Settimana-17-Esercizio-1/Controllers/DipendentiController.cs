using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Settimana_17_Esercizio_1.Models;

namespace Settimana_17_Esercizio_1.Controllers
{
    public class DipendentiController : Controller
    {
        // GET: Dipendenti
        public ActionResult Index()
        {
            List<Dipendenti> listaDipendenti = new List<Dipendenti>();
            listaDipendenti.Add(
                new Dipendenti(
                    "Gabriele",
                    "Bongio",
                    "Via dei Sedini 11, Morbegno",
                    "BNGGRL03A05I829R",
                    false,
                    0,
                    "muratore"
                )
            );
            listaDipendenti.Add(
                new Dipendenti(
                    "Giacomo",
                    "Poretti",
                    "Via Roma 23, Milano",
                    "PRTGCM71B12A748T",
                    true,
                    2,
                    "muratore"
                )
            );
            listaDipendenti.Add(
                new Dipendenti(
                    "Antonio",
                    "Fuoco",
                    "Via colombi 7, Genova",
                    "FCUNTN99A26C713H",
                    false,
                    1,
                    "capocantiere"
                )
            );
            listaDipendenti.Add(
                new Dipendenti(
                    "Federico",
                    "Ferri",
                    "Via dei Gangoli 7, Gela",
                    "FRRFDC78A212K",
                    true,
                    0,
                    "autista"
                )
            );

            return View(listaDipendenti);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Dipendenti d)
        {
            Response.Write(d.Nome + " " + d.Cognome);
            return View();
        }
    }
}
