using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class {
    internal class Masalar {

        List<Masa> masalarList;

        public List<Masa> MasalarList { get { return masalarList; } }

        public static Masalar Instance { get; private set; }
        
        public Masalar() {
            masalarList = new List<Masa>();
            
            if (Instance == null) {
                Instance = this;
            }
            else {
                throw new Exception("Cannot have more than one instance of Masalar!");
            }

            for (int i = 0; i < 10; i++) {
                Masa masa = new Masa(i + 1);
                masalarList.Add(masa);
            }

        }

        public void MasaEkle() {
            MasalarList.Add(new Masa(MasalarList.Count + 1));
        }

        public void MasaSil() {
            foreach (Siparis siparis in GetLastElement().SiparislerList) {
                Siparisler.Instance.SiparisIptalEt(siparis);
            }
            masalarList.RemoveAt(masalarList.Count - 1);
        }

        public Masa GetLastElement() {
            if (masalarList.Count == 0) return null;

            return masalarList[masalarList.Count - 1];
        }
    }
}
