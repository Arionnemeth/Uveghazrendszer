using System;
using System.Collections.Generic;
using System.Text;

namespace Uveghazrendszer
{
    internal class Cella
    {
        Pozicio pozicio;
        NovenyFaj noveyFaj;
        int egyedSzam;
        List<Szenzor> szenzorok;
        List<Riasztas> riasztasok;

        public Cella(int x, int y)
        {
            this.pozicio = new Pozicio(x, y);
            this.noveyFaj = null;
            this.egyedSzam = 0;
            this.szenzorok = new List<Szenzor>();
            this.riasztasok = new List<Riasztas>();
        }

        public int EgyedSzam { get => egyedSzam; set => egyedSzam = value; }
        internal Pozicio Pozicio { get => pozicio; set => pozicio = value; }
        internal NovenyFaj NoveyFaj { get => noveyFaj; set => noveyFaj = value; }
        internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
        internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }

        public bool UresE
        {
            get
            {
                return this.noveyFaj == null;
            }
        }

        public bool Telepit(NovenyFaj noveny, int mennyiseg)
        {
            bool sikeres = false;
            if (mennyiseg > 0 && UresE)
            {
                this.noveyFaj = noveny;
                this.egyedSzam = mennyiseg;
                Console.WriteLine($"{noveyFaj.Nev} telepítése sikeres volt!");
                sikeres = true;
            }
            else if (mennyiseg > 0 && this.noveyFaj.Equals(noveny))
            {
                Noveles(mennyiseg);
            }
            return sikeres;
        }

        public void Csokkentes(int mennyiseg)
        {
            this.egyedSzam -= mennyiseg;
            if (egyedSzam <= 0)
            {
                Urites();
            }
        }
        public void Urites()
        {
            this.noveyFaj = null;
            this.egyedSzam = 0;
        }

        public void Noveles(int mennyiseg)
        {
            this.egyedSzam += mennyiseg;
        }

        public override string ToString()
        {
            if (this.UresE)
            {
                return $"| {"Üres",8} |";
            }
            return $"| {this.noveyFaj.Azonosito,3} {this.egyedSzam,2}db |";
        }
    }
}
