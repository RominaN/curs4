using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs4_2
{
    class Imobil
    {   public string tipCasa { get; set; }
        public int  nrEtaje { get; set; }
        public double pret { get; set; }

      
            public string afiseazaDetaliiImobil()
            {
            return "tipCasa: " + tipCasa + "\nNumarEtaj: " + nrEtaje + "\nPret: " +pret;
            }
        

        public Imobil()
        {
            tipCasa = " ";
            nrEtaje = 0;
            pret = 0;
        }


        public Imobil(string type)
        {
            this.tipCasa = type;
            nrEtaje = 0;
            pret = 0.0;
        }
        public Imobil(string tipCasa, int nrEtaje, double pret)
        {
            this.tipCasa = tipCasa;
            this.nrEtaje = nrEtaje;
            this.pret = pret;
        }




    }
}
