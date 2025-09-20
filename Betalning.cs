
namespace UML_Class_Diagram
{
    // här har vi klassen betalning
    public class Betalning
    {
        // attributer
        public int betalningsID;
        public int belopp;
        public int betalningsDatum;
       
        // metoder
        public void GenomförBetalning()
        {
            Console.WriteLine("betalning genomförd");
        }
        public void Återbetalning()
        {
            Console.WriteLine("betalning återbetald");
        }
    }
    
}
