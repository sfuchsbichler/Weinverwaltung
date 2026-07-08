using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Weinverwaltung
{
    public class cls_Weinregal
    {
        PictureBox[,] m_regal = new PictureBox[6, 5];
        const int GROESSE = 73;
        public PictureBox m_selectedWein = null;
        public bool m_eingelagert = false;
        public bool m_vorhandenerWein = false;
        public cls_Wein m_wein = new cls_Wein();
        public cls_Weinregal(frm_Weinlager weinlager)
        {
            for (int x = 1; x < 7; x++)
            {
                PictureBox pbx_wein;
                for (int y = 1; y < 6; y++)
                {
                    pbx_wein = new PictureBox();
                    pbx_wein.Location = new System.Drawing.Point(40 + (GROESSE * (x-1)), 40 + (GROESSE * (y-1)));
                    pbx_wein.Size = new System.Drawing.Size(GROESSE, GROESSE);
                    pbx_wein.DoubleClick += new System.EventHandler(pbx_wein_DoubleClick);
                    pbx_wein.Click += new System.EventHandler(pbx_wein_Click);
                    pbx_wein.Tag = cls_DataProvider.Weinlager(x, y).ToString();
                    if (pbx_wein.Tag.ToString() != "0")
                        pbx_wein.Image = Properties.Resources.WeinfachFlasche;
                    else
                        pbx_wein.Image = Properties.Resources.Weinfach;
                    pbx_wein.SizeMode = PictureBoxSizeMode.Zoom;
                    m_regal[x-1, y-1] = pbx_wein;
                    weinlager.Controls.Add(pbx_wein);
                    
                }
            }
        }
        private void pbx_wein_DoubleClick(object sender, EventArgs e)
        {
            if(m_selectedWein.Tag.ToString() != "0")
            {
                cls_Fach fach = cls_DataProvider.WeinAnzeigen(Convert.ToUInt32(m_selectedWein.Tag));
                if (fach.Wein.Notizen == "")
                    fach.Wein.Notizen = "Keine Notizen vorhanden";
                MessageBox.Show(String.Format("{0} ist ein {1} von {2}. Der Wein wurde {3} in eine {4} Liter Flasche gefüllt und hat einen Alkoholgehalt von {5}%\rNotiz: {6}",fach.Wein.Bezeichnung, fach.Sorte, fach.Weingutname, fach.Wein.Jahrgang, fach.Wein.Liter, fach.Wein.Alkoholgehalt, fach.Wein.Notizen));
            }
        }

        private void pbx_wein_Click(object sender, EventArgs e)
        {
            PictureBox wein = sender as PictureBox;
            foreach (PictureBox Wein in m_regal)
            {
                Wein.BackColor = System.Drawing.Color.Transparent;
                if (Wein.Location == wein.Location)
                {
                    Wein.BackColor = System.Drawing.Color.Green;
                    m_selectedWein = Wein;
                }
            }
            if (m_wein.Menge > 0)
            {
                if (m_selectedWein != null)
                {
                    if (m_selectedWein.Tag.ToString() == "0")
                    {
                        if (m_eingelagert == false)
                        {
                            cls_DataProvider.NeuerWein(m_wein);
                            m_eingelagert = true;
                        }
                        else if (m_vorhandenerWein == false)
                        {
                            cls_DataProvider.VorhandenerWein(m_wein.Menge, m_wein.ID);
                            m_vorhandenerWein = true;
                        }
                        WeinEinlagern(m_wein.ID);
                        m_wein.Menge--;
                        if (m_wein.Menge > 0)
                            MessageBox.Show(String.Format("{0} Weine verbleibend.", m_wein.Menge), "HINWEIS");
                        else
                            MessageBox.Show("Alle Weine eingelagert.", "HINWEIS");
                    }
                    else
                    {
                        MessageBox.Show("Bitte wähle einen freien Lagerplatz aus!", "HINWEIS");
                    }
                }
                else
                {
                    MessageBox.Show("Bitte wähle einen Lagerplatz aus!", "HINWEIS");
                }
            }
            
        }

        public void KeinenWeinAuswaehlen()
        {
            m_selectedWein = null;
            foreach (PictureBox Wein in m_regal)
            {
                Wein.BackColor = System.Drawing.Color.Transparent;
            }
        }

        public void WeinEinlagern(uint id_wein)
        {
            int x = (m_selectedWein.Location.X - 40) / GROESSE + 1;
            int y = (m_selectedWein.Location.Y - 40) / GROESSE + 1;
            cls_DataProvider.Einlagern(id_wein, x, y);
            foreach (PictureBox Wein in m_regal)
            {
                if (Wein.Location == m_selectedWein.Location)
                {
                    Wein.Image = Properties.Resources.WeinfachFlasche;
                    Wein.BackColor = System.Drawing.Color.Transparent;
                    Wein.Tag = id_wein.ToString();
                }
            }
        }

        public void WeinKonsumieren()
        {
            int x = (m_selectedWein.Location.X - 40) / GROESSE + 1;
            int y = (m_selectedWein.Location.Y - 40) / GROESSE + 1;
            cls_DataProvider.WeinKonsumieren(x, y);
            foreach (PictureBox Wein in m_regal)
            {
                if (Wein.Location == m_selectedWein.Location)
                {
                    Wein.Image = Properties.Resources.Weinfach;
                    Wein.BackColor = System.Drawing.Color.Transparent;
                    Wein.Tag = "0";
                }
            }
        }
    }
}
