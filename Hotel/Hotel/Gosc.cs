using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Gosc
    {
        private string Imie;
        private string Nazwisko;

        public Gosc(string Imie, string Nazwisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
        }

        public override string ToString() 
        {
            return "Gosc," + Imie + Nazwisko ;
        }


    }
}
