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


            // här testar vi klassen 
            Bokning bokning1 = new Bokning();
            bokning1.avboka();
            bokning1.avslutahyra();
            // här testar vi klassen Hyresavtal
            Hyresavtal hyresavtal1 = new Bokning();
            hyresavtal1.förlängaHyra();
            hyresavtal1.avslutahyra();




















        }
    }
}
