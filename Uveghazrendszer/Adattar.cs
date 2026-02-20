using System;
using System.Collections.Generic;
using System.Text;

namespace Uveghazrendszer
{
    internal class Adattar
    {
        List<NovenyFaj> novenyek;
        UveghazRacs uveghaz;
        List<Kezelo> kezelok;

        internal UveghazRacs Uveghaz { get => uveghaz; set => uveghaz = value; }

        public Adattar()
        {
            this.kezelok = new List<Kezelo>() { new Kezelo("Gipsz Jakab", "GJ", Szerepkor.KERTESZ), new Kezelo("Aranka néni", "Ari", Szerepkor.ADMIN)};
            novenyek = new List<NovenyFaj>();
            this.uveghaz = new UveghazRacs(4);
            uveghaz.Parcellazas();
            
        }
        public void UjNoveny(NovenyFaj noveny)
        {
            novenyek.Add(noveny);
        }
        public void NovenyekListazasa()
        {
            foreach (var item in novenyek)
            {
                Console.WriteLine(item);
            }
        }

        public void Ultetes()
        {
            uveghaz.Ultetes(novenyek);
        }
    }
}
