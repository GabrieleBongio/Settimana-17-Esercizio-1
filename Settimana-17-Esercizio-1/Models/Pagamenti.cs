using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Settimana_17_Esercizio_1.Models
{
    public class Pagamenti
    {
        public string Periodo_Pagamento { get; set; }
        public double Ammontare { get; set; }
        public char Tipo { get; set; }

        public Pagamenti() { }

        public Pagamenti(string periodo_Pagamento, double ammontare, char tipo)
        {
            Periodo_Pagamento = periodo_Pagamento;
            Ammontare = ammontare;
            Tipo = tipo;
        }
    }
}
