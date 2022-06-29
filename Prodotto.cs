using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto{
        private int codice { get; }
        string nome { get; set; }
        string descrizione { get; set;}

        double prezzo { get; set; }

        int ivaPercentuale { get; set; }

        public Prodotto(string nome, string descrizione, double prezzo, int ivaPercentuale)
        {
            this.codice = new Random().Next(100, 1001);
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.ivaPercentuale = ivaPercentuale;
        }

        public double getPrezzo(){
            return this.prezzo;
        }

        public double getPrezzoConIVA(){
            return this.prezzo + (this.prezzo / 100 * this.ivaPercentuale);
        }

        public string getFullName(){
            return this.codice.ToString() + " " + this.nome;
        }


    }
}
