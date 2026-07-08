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
    public partial class dlg_WeingutVerwalten : Form
    {
        public dlg_WeingutVerwalten()
        {
            InitializeComponent();
            lbx_Weingueter.DisplayMember = "Name";
            lbx_Weingueter.Items.AddRange(cls_DataProvider.AlleWeingueterAnzeigen().ToArray());
        }

        private void btn_Neu_Click(object sender, EventArgs e)
        {
            dlg_Weingut neu = new dlg_Weingut();
            if (neu.ShowDialog() == DialogResult.OK)
            {
                cls_DataProvider.NeuesWeingut(neu.Weingut);
                lbx_Weingueter.Items.Add(neu.Weingut);
            }
        }

        private void Aendern()
        {
            if (lbx_Weingueter.SelectedItem != null)
            {
                cls_Weingut weingut = lbx_Weingueter.SelectedItem as cls_Weingut;
                dlg_Weingut neu = new dlg_Weingut(weingut);
                if (neu.ShowDialog() == DialogResult.OK)
                {
                    lbx_Weingueter.Items.Remove(lbx_Weingueter.SelectedItem);
                    cls_DataProvider.WeingutAendern(neu.Weingut);
                    lbx_Weingueter.Items.Add(neu.Weingut);
                }
            }
        }

        private void btn_Aendern_Click(object sender, EventArgs e)
        {
            Aendern();
        }

        private void lbx_Weingueter_DoubleClick(object sender, EventArgs e)
        {
            Aendern();
        }

        private void btn_Loeschen_Click(object sender, EventArgs e)
        {
            if (lbx_Weingueter.SelectedItem != null)
            {
                cls_Weingut weingut = lbx_Weingueter.SelectedItem as cls_Weingut;
                cls_DataProvider.WeingutLoeschen(weingut);
                lbx_Weingueter.Items.Remove(weingut);
            }
        }
    }
}
