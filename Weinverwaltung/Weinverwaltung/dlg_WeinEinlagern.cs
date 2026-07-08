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
    public partial class dlg_WeinEinlagern : Form
    {
        public cls_Wein Wein
        {
            get;
            set;
        }
        public dlg_WeinEinlagern()
        {
            InitializeComponent();
            cob_Sorte.Items.AddRange(cls_DataProvider.AlleSortenAnzeigen().ToArray());
            cob_Sorte.DisplayMember = "Bezeichnung";
            cob_Weingut.Items.AddRange(cls_DataProvider.AlleWeingueterAnzeigen().ToArray());
            cob_Weingut.DisplayMember = "Name";
            Wein = new cls_Wein();
            nud_Menge.Maximum = cls_DataProvider.FreierPlatz();
        }

        private void btn_Einlagern_Click(object sender, EventArgs e)
        {
            if(Wein.ID != 0)
            {
                Wein.Menge = Convert.ToInt32(nud_Menge.Value);
                DialogResult = DialogResult.Yes;
            }
            else
            {
                if (tbx_Bezeichnung.Text == "" || cob_Sorte.SelectedItem == null || nud_Alkoholgehalt.Value == 0 || nud_Jahrgang.Value == 0 || nud_Liter.Value == 0 || nud_Einzelpreis.Value == 0 || cob_Weingut.SelectedItem == null)
                {
                    MessageBox.Show("Bitte füllen Sie alle Felder aus!", "HINWEIS");
                }
                else
                {
                    Wein = new cls_Wein(tbx_Bezeichnung.Text, nud_Alkoholgehalt.Value, Convert.ToDouble(nud_Einzelpreis.Value), Convert.ToDouble(nud_Liter.Value), Convert.ToInt32(nud_Jahrgang.Value), Convert.ToInt32(nud_Menge.Value), Convert.ToUInt32((cob_Weingut.SelectedItem as cls_Weingut).ID), Convert.ToUInt32((cob_Sorte.SelectedItem as cls_Sorte).ID));
                    DialogResult = DialogResult.OK;
                }
            }
            
        }

        private void btn_VorhandenerWein_Click(object sender, EventArgs e)
        {
            dlg_VorhandenerWein wein = new dlg_VorhandenerWein();
            if(wein.ShowDialog() == DialogResult.OK )
            {
                tbx_Bezeichnung.Text = wein.Wein.Bezeichnung;
                tbx_Bezeichnung.ReadOnly = true;
                cob_Sorte.Items.Clear();
                cob_Sorte.Items.Add(wein.Wein.ID_Sorte);
                cob_Sorte.SelectedItem = wein.Wein.ID_Sorte;
                nud_Alkoholgehalt.Value = wein.Wein.Alkoholgehalt;
                nud_Alkoholgehalt.ReadOnly = true;
                nud_Jahrgang.Value = new decimal(wein.Wein.Jahrgang);
                nud_Jahrgang.ReadOnly = true;
                nud_Liter.Value = new decimal(wein.Wein.Liter);
                nud_Liter.ReadOnly = true;
                nud_Einzelpreis.Value = new decimal(wein.Wein.Einzelpreis);
                nud_Einzelpreis.ReadOnly = true;
                cob_Weingut.Items.Clear();
                cob_Weingut.Items.Add(wein.Wein.ID_Weingut);
                cob_Weingut.SelectedItem = wein.Wein.ID_Weingut;
                Wein = wein.Wein;
            }
        }
    }
}
