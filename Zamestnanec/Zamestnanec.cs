using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamestnanec
{
    class Zamestnanecc : Osoba
    {
        private double _mon;

        public string Edu { get; set; }
        public string PracPos { get; set; }
        public double Mon {
            get { return _mon; }
            set
            {
                if (value > 0)
                {
                    _mon = value;
                }
                else
                {
                    throw new ArgumentException("error, enter double number");
                }
            }
        }
        public Zamestnanecc(string n, string s, DateTime dn, string e, string pp, double m) : base (n,s,dn)
        {
            Edu = e;
            PracPos = pp;
            Mon = m;
        }
    }
}
