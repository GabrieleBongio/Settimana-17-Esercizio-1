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
    public class PagamentiController : Controller
    {
        // GET: Pagamenti
        public ActionResult Index()
        {
            List<Pagamenti> listaPagamenti = new List<Pagamenti>();

            string connString = ConfigurationManager
                .ConnectionStrings["myConnection"]
                .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string query = "SELECT * FROM Pagamenti";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaPagamenti.Add(
                        new Pagamenti(
                            reader.GetInt32(1),
                            reader.GetString(2),
                            reader.GetSqlMoney(3).ToDouble(),
                            Convert.ToChar(reader.GetString(4))
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

            return View(listaPagamenti);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pagamenti p)
        {
            string connString = ConfigurationManager
                .ConnectionStrings["myConnection"]
                .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string query =
                    "INSERT INTO Pagamenti (Dipendente, Periodo_Pagamento, Ammontare, Tipo ) VALUES (@Dipendente, @Periodo_Pagamento, @Ammontare, @Tipo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Dipendente", p.Dipendente);
                cmd.Parameters.AddWithValue("@Periodo_Pagamento", p.Periodo_Pagamento);
                cmd.Parameters.AddWithValue("@Ammontare", p.Ammontare);
                cmd.Parameters.AddWithValue("@Tipo", p.Tipo);
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
