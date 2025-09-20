using System.Runtime.Loader;

namespace UML_Class_Diagram
{
    internal class Program
    {
        // här kör vi programmet för att testa klasserna
        static void Main(string[] args)
        {
            // här testar vi klassen kund
            Kund ozzy = new Kund();
            ozzy.bokaBil();
            ozzy.betala();


            // här testar vi klassen som abstract
           
            Hyresavtal bokning = new Bokning();
            bokning.Avslutahyra();

            // här testar vi klassen fordon 
            Fordon volvo = new Bil();
            volvo.Tillgänglighet();
            volvo.Underhåll();
            // här testar vi subklassen bil
            Bil audi = new Bil();
            audi.Tanka();
            audi.Tvätta();

            // här testar vi klassen betalning
            Betalning betalning1 = new Betalning();
            betalning1.GenomförBetalning();
            betalning1.Återbetalning();























        }
    }
}
