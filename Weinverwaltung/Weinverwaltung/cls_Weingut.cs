using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weinverwaltung
{
    public  class cls_Weingut
    {
        public cls_Weingut()
        {

        }
        public cls_Weingut(string name, string strasse, string plz, string ort, string email, string tel)
        {
            Name = name;
            Strasse = strasse;
            PLZ = plz;
            Ort = ort;
            EMail = email;
            Telefon = tel;
        }
        public cls_Weingut(uint id, string name, string strasse, string plz, string ort, string email, string tel) : this(name, strasse, plz, ort, email, tel)
        {
            ID = id;
        }

        public UInt32 ID
        { get; set; }
        public string Name
        { get; set; }
        public string Strasse
        { get; set; }
        public string PLZ
        { get; set; }
        public string Ort
        { get; set; }
        public string EMail
        { get; set; }
        public string Telefon
        { get; set; }

    }
}
