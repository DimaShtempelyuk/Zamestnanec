using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamestnanec
{
    class Osoba
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Dob { get; set; }
        public Osoba(string n, string s, DateTime dn)
        {
            Name = n;
            Surname = s;
            Dob = dn;
        }
    }
}
