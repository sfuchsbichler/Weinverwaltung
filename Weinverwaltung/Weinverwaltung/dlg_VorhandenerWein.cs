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
    public partial class dlg_VorhandenerWein : Form
    {
        public cls_Wein Wein
        { get; set; }
        public dlg_VorhandenerWein()
        {
            InitializeComponent();
            lbx_Weine.DisplayMember = "Anzeige";
            lbx_Weine.Items.AddRange(cls_DataProvider.AlleWeineAnzeigen().ToArray());
        }

        private void btn_Auswaehlen_Click(object sender, EventArgs e)
        {
            if(lbx_Weine.SelectedItem != null)
            {
                Wein = lbx_Weine.SelectedItem as cls_Wein;
            }
        }
    }
}
