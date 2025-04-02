using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labbb_4
{
    // Klass som beskriver en person
    public class Person
    {
        public string Namn { get; set; }          // Personens namn
        public Gender Kön { get; set; }           // Personens kön
        public Hair Hår { get; set; }             // Personens hår
        public DateTime Födelsedatum { get; set; } // Födelsedatum
        public string Ögonfärg { get; set; }      // Ögonfärg

        // Konstruktor som skapar en person
        public Person(string namn, Gender kön, Hair hår, DateTime födelsedatum, string ögonfärg)
        {
            Namn = namn;
            Kön = kön;
            Hår = hår;
            Födelsedatum = födelsedatum;
            Ögonfärg = ögonfärg;
        }

        // Returnerar information om personen
        public override string ToString()
        {
            return $"Namn: {Namn}\nKön: {Kön}\nHår: {Hår}\nFödelsedatum: {Födelsedatum.ToShortDateString()}\nÖgonfärg: {Ögonfärg}";
        }
    }
}
