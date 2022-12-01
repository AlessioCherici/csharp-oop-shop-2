using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_shop_2
    {
    public class Acqua : Prodotto
        {
        private double litri;
        private double pH;
        private string sorgente;

        public Acqua(string nome, string descrizione, double litri, double pH,
            string sorgente, double prezzo, double iva) : base(nome, descrizione, prezzo, iva)
            {
            this.litri = litri;
            this.pH = pH;   
            this.sorgente = sorgente;
            }

        //--------------------------------- Metodi Get ---------------------------------

        public double GetLitri()
            {
            return this.litri;
            }
        public double GetpH()
            {
            return this.pH;
            }
        public string GetSorgente()
            {
            return this.sorgente;
            }
        //--------------------------------- Metodi set ---------------------------------

        public void SetLitri()
            {
            this.litri = litri;
            }
        public void SetpH()
            {
            this.pH = pH;
            }
        public void SetSorgente()
            {
            this.sorgente = sorgente;
            }

        public override void stampaTutto()
            {
            Console.WriteLine("---------" + base.getNome() + "---------" + "\n");
            Console.WriteLine("Descrizione: " + base.getDescrizione());
            Console.WriteLine("Capienza: " + this.litri + "L");
            Console.WriteLine("pH: " + this.pH);
            Console.WriteLine("Sorgente: " + this.sorgente);
            Console.WriteLine("Codice Prodotto: " + base.getNumeroProdotto().ToString().PadLeft(8, '0'));
            Console.WriteLine("Iva prodotto: " + base.getIva() + "%");
            Console.WriteLine("Prezzo con Iva: " + base.prezzoIvato(base.getPrezzo(), base.getIva()) + "\n" );
            Console.WriteLine("-----------------------------------");
            }
        }
    }
