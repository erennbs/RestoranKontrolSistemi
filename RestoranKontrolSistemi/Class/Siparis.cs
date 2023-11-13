using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class
{
    internal class Siparis {

        Urun urun;
        int miktar;
        
        public Siparis(Urun urun, int miktar) { 
            this.urun = urun;
            this.miktar = miktar;
        }
    }
}
