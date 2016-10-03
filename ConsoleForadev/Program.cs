using DAOForadev;
using Foradev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForadev
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Rubrique> listeRubriques = DAOPrincipale.GetRubriques();
            //foreach (Rubrique r in listeRubriques)
            //{
            //    Console.WriteLine(r);
            //}
            //Console.ReadKey();

            List<Sujet> listeSujets = DAOPrincipale.GetSujetsByRubrique("développement");
            foreach (Sujet s in listeSujets)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
