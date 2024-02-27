using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

            string connString = ConfigurationManager
                .ConnectionStrings["myConnection"]
                .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string query = "SELECT * FROM Dipendenti";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaDipendenti.Add(
                        new Dipendenti(
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetBoolean(5),
                            reader.GetInt32(6),
                            reader.GetString(7)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

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
            string connString = ConfigurationManager
                .ConnectionStrings["myConnection"]
                .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string query =
                    "INSERT INTO Dipendenti (Nome, Cognome, Indirizzo, CF, Coniugato, NFigli, Mansione) VALUES (@Nome, @Cognome, @Indirizzo, @CF, @Coniugato, @NFigli, @Mansione)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", d.Nome);
                cmd.Parameters.AddWithValue("@Cognome", d.Cognome);
                cmd.Parameters.AddWithValue("@Indirizzo", d.Indirizzo);
                cmd.Parameters.AddWithValue("@CF", d.CF);
                cmd.Parameters.AddWithValue("@Coniugato", d.Coniugato);
                cmd.Parameters.AddWithValue("@NFigli", d.NFigli);
                cmd.Parameters.AddWithValue("@Mansione", d.Mansione);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return RedirectToAction("Index");
        }
    }
}
