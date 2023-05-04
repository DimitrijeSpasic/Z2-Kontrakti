using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2_Kontrakti
{
    internal class Adresar
    {
        private Dictionary<string, Kontakt> kontakti = new Dictionary<string, Kontakt>();
        bool Dodaj(Kontakt k)
        {
            if(kontakti.ContainsKey(k.GlavniBroj))
            {
                return false;
            }
            else
            {
                kontakti.Add(k.GlavniBroj, k);
            }
            return true;
        }
        bool Dodaj(string ime, string prezime, string glavnibroj)
        {
            Kontakt ko = new Kontakt(ime, prezime, glavnibroj);
            return(Dodaj(ko));
        }
        bool Blokiraj(string broj)
        {
            if(kontakti.ContainsKey(broj))
            {
                kontakti.Remove(broj);
                return true;
            }
            return false;
        }
        void Share(string FileName, string glavniBroj)
        {

        }
        void Receive(string FileName)
        {

        }
        void Backup (string FileName)
        {

        }
    }
}
