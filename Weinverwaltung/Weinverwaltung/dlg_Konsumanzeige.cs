using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weinverwaltung
{
    public partial class dlg_Konsumanzeige : Form
    {
        public dlg_Konsumanzeige()
        {
            InitializeComponent();
            lbx_Konsum.DisplayMember = "AnzeigeKonsum";
            lbx_Konsum.Items.AddRange(cls_DataProvider.WeinMenge().ToArray());
        }
    }
}
