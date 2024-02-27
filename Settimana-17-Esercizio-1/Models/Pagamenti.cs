using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Settimana_17_Esercizio_1.Models
{
    public class Pagamenti
    {
        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        [ForeignKey("IdDipendente")]
        public int Dipendente { get; set; }
        public Dipendenti Dipendenti { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        [MaxLength(30, ErrorMessage = "Lunghezza massima di 30 caratteri")]
        public string Periodo_Pagamento { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        public double Ammontare { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        public char Tipo { get; set; }

        public Pagamenti() { }

        public Pagamenti(int dipendente, string periodo_Pagamento, double ammontare, char tipo)
        {
            Dipendente = dipendente;
            Periodo_Pagamento = periodo_Pagamento;
            Ammontare = ammontare;
            Tipo = tipo;
        }
    }
}
