
namespace UML_Class_Diagram
{
    // här har vi subklassen bokning som ska ärva vissa attibuter från Hyresavtal
    public class Bokning : Hyresavtal
    {
        // attributer
        public int bokningsnummer;

        public string address;

        public DateTime bokningsDatum;

        // metoder
        public void avboka()
        {
            Console.WriteLine("kund kan avboka bokning");
        }
        // här skriver vi över metod från Hyresavtal
        public override void avslutahyra()
        {
            Console.WriteLine("Hyresavtal kan inte avslutas efter 24 timmar ");
        }   
    }
}
