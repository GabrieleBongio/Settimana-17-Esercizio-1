using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Settimana_17_Esercizio_1.Models
{
    public class Dipendenti
    {
        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        [MaxLength(40, ErrorMessage = "Lunghezza massima di 40 caratteri")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        [MaxLength(40, ErrorMessage = "Lunghezza massima di 40 caratteri")]
        public string Cognome { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        [MaxLength(200, ErrorMessage = "Lunghezza massima di 200 caratteri")]
        public string Indirizzo { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        [MaxLength(16, ErrorMessage = "Il CF ha una lunghezza di esattamente 16 caratteri")]
        [MinLength(16, ErrorMessage = "Il CF ha una lunghezza di esattamente 16 caratteri")]
        public string CF { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        public bool Coniugato { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        [Range(0, 5000, ErrorMessage = "Questo numero deve essere compreso tra 0 e 5000")]
        public int NFigli { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio")]
        [MaxLength(50, ErrorMessage = "Lunghezza massima di 50 caratteri")]
        public string Mansione { get; set; }

        public Dipendenti() { }

        public Dipendenti(
            string nome,
            string cognome,
            string indirizzo,
            string cf,
            bool coniugato,
            int nfigli,
            string mansione
        )
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Indirizzo = indirizzo;
            this.CF = cf;
            this.Coniugato = coniugato;
            this.NFigli = nfigli;
            this.Mansione = mansione;
        }
    }
}
