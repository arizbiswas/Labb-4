using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labbb_4
{
    // Struct som beskriver hår
    public struct Hair
    {
        public string Färg { get; set; }   // Hårfärg
        public string Längd { get; set; }  // Hårlängd

        // Konstruktor för att skapa hår
        public Hair(string färg, string längd)
        {
            Färg = färg;
            Längd = längd;
        }

        // Returnerar information om håret
        public override string ToString()
        {
            return $"Färg: {Färg}, Längd: {Längd}";
        }
    }
}
