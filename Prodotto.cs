using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto{
        public int codice { get; }
        public string nome { get; set; }
        public string descrizione { get; set;}

        public double prezzo { get; set; }

        public int ivaPercentuale { get; set; }

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

        public string getFullCode(){
            string fallBack = "";

            //se il codice non raggiunge 8 numeri, faccio un ciclo dove concateno la stringa di fallback
            if (this.codice.ToString().Length < 8){
                for (int i = this.codice.ToString().Length; i < 8; i++){
                    fallBack += "0";

                }
                
                fallBack += this.codice.ToString();
                return fallBack;
            }
            else{
                return this.codice.ToString();
            }
            
        }


    }
}
