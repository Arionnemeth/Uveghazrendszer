using System;
using System.Collections.Generic;
using System.Text;

namespace Uveghazrendszer
{
    internal class NovenyFaj
    {
        string nev;
        int nedvességtartalom; // 100 az ideális
        int egeszsegszint; // 100 a max
        int optimalisSuruseg;  

        public NovenyFaj(string nev, int optimalisSuruseg)
        {
            this.nev = nev;
            this.optimalisSuruseg = optimalisSuruseg;
            this.nedvességtartalom = 100;
            this.egeszsegszint = 100;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Nedvességtartalom { get => nedvességtartalom; set => nedvességtartalom = value; }
        public int Egeszsegszint { get => egeszsegszint; set => egeszsegszint = value; }
        public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }

        public string Azonosito { get { return this.nev.Substring(0, 3); } }


        public override bool Equals(object obj)
        {
            obj = obj as NovenyFaj;
            if (this.nev == ((NovenyFaj)(obj)).nev)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"{this.nev} nedvesseg: {this.nedvességtartalom} egeszseg: {this.egeszsegszint} ideális egyedszám: {this.optimalisSuruseg}";
        }
    }
}
