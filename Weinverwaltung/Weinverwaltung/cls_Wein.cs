using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weinverwaltung
{
    public class cls_Wein
    {
        public cls_Wein()
        {

        }
        public cls_Wein(string bez, decimal gehalt, double preis, double liter, int jahr, int menge, uint idwg, uint idsorte)
        {
            Bezeichnung = bez;
            Alkoholgehalt = gehalt;
            Einzelpreis = preis;
            Liter = liter;
            Jahrgang = jahr;
            Menge = menge;
            ID_Weingut = idwg;
            ID_Sorte = idsorte;
        }

        public UInt32 ID
        { get; set; }
        public string Bezeichnung
        { get; set; }
        public decimal Alkoholgehalt
        { get; set; }
        public string Notizen
        { get; set; }
        public double Einzelpreis
        { get; set; }
        public double Liter
        { get; set; }
        public Int32 Jahrgang
        { get; set; }
        public Int32 Menge
        { get; set; }
        public UInt32 ID_Weingut
        { get; set; }
        public UInt32 ID_Sorte
        { get; set; }
        public string Sorte
        { get; set; }
        public string Weingutname
        { get; set; }

        public string Anzeige
        {
            get
            {
                return String.Format("{0} von {1}, {2}, Jahr {3}", Bezeichnung, Weingutname, Sorte, Jahrgang);
            }
        }
        public string AnzeigeKonsum
        {
            get
            {
                return String.Format("{0} von {1}, {2}, Jahr {3}, {4} Stk.", Bezeichnung, Weingutname, Sorte, Jahrgang, Menge);
            }
        }
    }
}
