using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Pokoj : IComparable <Pokoj>
    {
        private int nrPokoju;
        private double cenaZaDzien;

        public Pokoj(int nrPokoju, double cenaZaDzien )
        {
            this.nrPokoju = nrPokoju;
            this.cenaZaDzien = cenaZaDzien;
        }

        public override string ToString()
        {
            return "Pokuj," + "nr:" + nrPokoju + "," + "cena za dzien:" + cenaZaDzien;
        }

        public double NrPokoju()
        {
            return nrPokoju;
        }

        public double CenazaDzien()
        {
            return cenaZaDzien;
        }

        public int CompareTo(Pokoj obj)
        {
            if (this.nrPokoju == obj.nrPokoju) return this.cenaZaDzien.CompareTo(obj.cenaZaDzien);
            return obj.nrPokoju.CompareTo(this.nrPokoju);
        } 
    }
}
