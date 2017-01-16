using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class hotel : IData 
    {
        private SortedDictionary<Pokoj,string> rezerwacja = new SortedDictionary<Pokoj,string>();
        private DateTime Data;

        public void UstawDate(DateTime Time)
        {
            this.Data = Time;
        }
        public bool SprawdzDate()
        {
            return (Data > DateTime.Now) ? true : false;
        }
    }
}
