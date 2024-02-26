using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Settimana_17_Esercizio_1.Models
{
    public class Dipendenti
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CF { get; set; }
        public bool Coniugato { get; set; }
        public int NFigli { get; set; }
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
