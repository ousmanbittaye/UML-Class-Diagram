
namespace UML_Class_Diagram
{
    // här har vi subklassen bokning som ska ärva vissa attibuter från Hyresavtal
    public class Bokning : Hyresavtal
    {
        // attributer
        public int bokningsnummer;

        public string address;

        public int bokningsDatum;

        // metoder
        public void Avboka()
        {
            Console.WriteLine("kund kan avboka bokning");
        }
        // här skriver vi över metod från Hyresavtal
        public override void Avslutahyra()
        {
            Console.WriteLine("Hyresavtal kan inte avslutas efter 24 timmar ");
        }   
    }
}
