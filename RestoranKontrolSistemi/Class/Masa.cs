using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RestoranKontrolSistemi.Class
{
    internal class Masa
    {
        public int MasaNumarasi { get; private set; }
        public bool Dolu { get; private set; }
        public BindingList<Siparis> SiparislerList {  get; private set; }


        public Masa(int masaNumarasi) {
            this.MasaNumarasi = masaNumarasi;
            this.Dolu = false;
            this.SiparislerList = new BindingList<Siparis>();
        }

        public void MasaAc() {
            Dolu = true;
        }

        public void MasaKapat() {
            SiparislerList.Clear();
            Dolu = false;
        }

        public void SiparisEkle(Siparis siparis) {
            SiparislerList.Add(siparis);
        }
    }
}
