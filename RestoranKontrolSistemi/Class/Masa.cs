using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class
{
    internal class Masa
    {
        int masaNumarasi;
        bool dolu;
        List<Siparis> siparisler;

        public Masa(int masaNumarasi) {
            this.masaNumarasi = masaNumarasi;
            this.dolu = false;
            this.siparisler = new List<Siparis>();
        }

        public void MasaAc() {
            dolu = true;
        }

        public void MasaKapat() {
            siparisler.Clear();
        }

        public void SiparisEkle(Siparis siparis) {
            siparisler.Add(siparis);
        }
    }
}
