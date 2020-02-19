using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs4_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Imobil imo = new Imobil();
            imo.afiseazaDetaliiImobil();
            imo.tipCasa = "Casa";
            imo.nrEtaje = 1;
            imo.pret=25.23;

            Console.WriteLine ("tipCasa: " + imo.tipCasa + "\nNumarEtaje: " + imo.nrEtaje + "\nPret: " + imo.pret);

            Imobil imo2 = new Imobil("apartament");
            imo2.nrEtaje = 5;
            imo2.pret = 72.57;
            Console.WriteLine();
            Console.WriteLine("tipCasa: " + imo2.tipCasa + "\nNumarEtaj: " + imo2.nrEtaje + "\nPret: " + imo2.pret);

            Imobil imo3 = new Imobil("bloc", 7, 50500);
            Console.WriteLine();
            Console.WriteLine("tipCasa: " + imo3.tipCasa + "\nNumarEtaj: " + imo3.nrEtaje + "\nPret: " + imo3.pret);

            Console.ReadLine();
        }
    }
}
