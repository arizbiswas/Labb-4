using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Labbb4_01;

namespace Labbb4_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>(); // Lista för personer
            bool kör = true; // Variabel för att hålla loopen igång

            // Programloop
            while (kör)
            {
                // Visar meny
                Console.WriteLine("\n--- MENY ---");
                Console.WriteLine("1. Lägg till person");
                Console.WriteLine("2. Visa personer");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj: ");
                string val = Console.ReadLine();

                // Kollar vad användaren valt
                switch (val)
                {
                    case "1":
                        LäggTillPerson(personer);
                        break;
                    case "2":
                        VisaPersoner(personer);
                        break;
                    case "3":
                        Console.WriteLine("Programmet avslutas...");
                        kör = false;
                        break;
                    default:
                        Console.WriteLine("Fel val, försök igen.");
                        break;
                }
            }
        }

        // Metod för att lägga till person
        static void LäggTillPerson(List<Person> personer)
        {
            try
            {
                Console.Write("Förnamn: ");
                string förnamn = Console.ReadLine();

                Console.Write("Efternamn: ");
                string efternamn = Console.ReadLine();

                Console.Write("Kön (Man/Kvinna/IckeBinär/Annan): ");
                string könInput = Console.ReadLine();
                if (!Enum.TryParse(könInput, true, out Gender kön))
                {
                    Console.WriteLine("Fel kön, försök igen.");
                    return;
                }

                Console.Write("Hårfärg: ");
                string hårfärg = Console.ReadLine();

                Console.Write("Hårlängd: ");
                string hårlängd = Console.ReadLine();

                Console.Write("Ögonfärg: ");
                string ögonfärg = Console.ReadLine();

                Console.Write("Födelsedatum (yyyy-MM-dd): ");
                string datumInput = Console.ReadLine();
                if (!DateTime.TryParse(datumInput, out DateTime födelsedatum))
                {
                    Console.WriteLine("Fel datumformat, försök igen.");
                    return;
                }

                // Skapar person och lägger till i listan
                Hair hår = new Hair(hårfärg, hårlängd);
                Person p = new Person(förnamn, efternamn, kön, hår, födelsedatum, ögonfärg);
                personer.Add(p);

                Console.WriteLine("Person tillagd!");
            }
            catch (Exception)
            {
                Console.WriteLine("Något gick fel, försök igen.");
            }
        }

        // Metod för att visa alla personer
        static void VisaPersoner(List<Person> personer)
        {
            if (personer.Count == 0)
            {
                Console.WriteLine("Ingen person finns inlagd.");
                return;
            }

            Console.WriteLine("\n--- Personer ---");
            foreach (Person p in personer)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
