

namespace UML_Class_Diagram
{
    // här har vi klassen hyresavtal som ska ärva vissa attibuter från Kund så som nam och telefonnummer.
    public abstract class Hyresavtal
    {
        // attributer
        public int kundnummer;

        public DateTime startDatum;

        public DateTime slutDatum;

        public int prisPerDag;

        // metoder
        public void FörlängaHyra()
        {
            Console.WriteLine($"kund kan förlänga hyresavtal");
        }
        public abstract void Avslutahyra(); 
        
       






      
    }
}
