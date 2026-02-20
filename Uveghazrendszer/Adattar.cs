using System;
using System.Collections.Generic;
using System.Text;

namespace Uveghazrendszer
{
    internal class Adattar
    {
        List<NovenyFaj> novenyek;
        public Adattar()
        {
            novenyek = new List<NovenyFaj>();
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
    }
}
