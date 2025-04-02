using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labbb_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar ett hår-objekt
            Hair hår = new Hair("Svart", "Kort");

            // Skapar en person med information
            Person person = new Person("Cristiano Ronaldo", Gender.Man, hår, new DateTime(1985, 2, 5), "Brun");

            // Skriver ut personens information
            Console.WriteLine(person.ToString());
        }
    }
}
