using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class {
    
    internal class Siparisler {
        
        public static Siparisler Instance { get; private set; }

        public BindingList<Siparis> SiparislerQueue { get; private set; }


        public Siparisler() { 
            if (Instance == null) {
                Instance = this;
            } else {
                throw new Exception("Cannot have more than one instance of Siparisler!");
            }

            SiparislerQueue = new BindingList<Siparis>();
        }

        public void SırayaEkle(Siparis siparis) {
            SiparislerQueue.Add(siparis);
        }

        public Siparis SıradanCikar() {
            // Removes and returns the Siparis in the beginning of the list.
            if (SiparislerQueue.Count == 0) return null;
            
            Siparis siparis = SiparislerQueue[0];
            siparis.SiparisHazir();
            SiparislerQueue.RemoveAt(0);
            return siparis;
        }

        public void SiparisIptalEt(Siparis siparis) {
            SiparislerQueue.Remove(siparis);
        }

    }


}
