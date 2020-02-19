using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pers = new Animal();
            pers.afiseazaDetaliiAnimal();
            pers.tipAnimal = "vacuta";
            pers.culoare = "maro";
            pers.varsta = 10;
            Console.WriteLine();
            Console.WriteLine("TipAnimal: " + pers.tipAnimal + "\nCuloare: " + pers.culoare + "\nVarsta: " + pers.varsta);
           

            Animal pers2 = new Animal("caine");
            pers2.culoare = "negru";
            pers2.varsta = 4;
            Console.WriteLine();
            Console.WriteLine("TipAnimal: " + pers2.tipAnimal + "\nCuloare: " + pers2.culoare + "\nVarsta: " + pers2.varsta);
            

            Animal pers3 = new Animal("cal", "alb", 6);
            Console.WriteLine();
            Console.WriteLine("TipAnimal: " + pers3.tipAnimal + "\nCuloare: " + pers3.culoare + "\nVarsta: " + pers3.varsta);
            Console.ReadKey();


        }

    }
}

