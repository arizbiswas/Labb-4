using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labbb4_01
{
    // Struct som beskriver hår
    public struct Hair
    {
        public string Färg { get; set; }    // Hårfärg
        public string Längd { get; set; }   // Hårlängd

        // Konstruktor
        public Hair(string färg, string längd)
        {
            Färg = färg;
            Längd = längd;
        }

        // Returnerar hårinformation
        public override string ToString()
        {
            return $"Färg: {Färg}, Längd: {Längd}";
        }
    }
}
