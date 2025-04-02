
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Labbb4_01;

namespace Labbb4_01
{
    // Klass som beskriver en person
    public class Person
    {
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public Gender Kön { get; set; }
        public Hair Hår { get; set; }
        public DateTime Födelsedatum { get; set; }
        public string Ögonfärg { get; set; }

        // Konstruktor
        public Person(string förnamn, string efternamn, Gender kön, Hair hår, DateTime födelsedatum, string ögonfärg)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
            Kön = kön;
            Hår = hår;
            Födelsedatum = födelsedatum;
            Ögonfärg = ögonfärg;
        }

        // Returnerar information om personen
        public override string ToString()
        {
            return $"Namn: {Förnamn} {Efternamn}\nKön: {Kön}\nHår: {Hår}\nFödelsedatum: {Födelsedatum:yyyy-MM-dd}\nÖgonfärg: {Ögonfärg}\n";
        }
    }
}
