using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weinverwaltung
{
    public class cls_Sorte
    {
        public cls_Sorte()
        {

        }
        public cls_Sorte(string bez)
        {
            Bezeichnung = bez;
        }
        public UInt32 ID
        { get; set; }
        public string Bezeichnung
        { get; set; }
    }
}
