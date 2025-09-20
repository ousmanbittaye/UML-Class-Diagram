

namespace UML_Class_Diagram
{
    // här har vi klassen fordon.
    public class Fordon
    {
        // attributer
        public int registreringsnummer;
        public int prisPerDag;
        public string typavfordon;

        // metoder
        public void Tillgänglighet()
        {
            Console.WriteLine("fordon är tillgänglig");

        }
        public void Underhåll()
        {
            Console.WriteLine("fordon är underhåll");
        }



    }

    // här har vi subklassen bil som ska ärva vissa attibuter från fordon

    public class Bil : Fordon
    {
        // attributer
        public string märke;
        public string modell;
        public int årsmodell;
        // metoder
        public void Tanka()
        {
            Console.WriteLine("bil är tankad");
        }
        public void Tvätta()
        {
            Console.WriteLine("bil är tvättad");
        }

    } 
}
