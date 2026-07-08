using Microsoft.Win32;
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
    public partial class frm_Weinlager : Form
    {
        public cls_Weinregal m_weinregal;
        public frm_Weinlager()
        {
            InitializeComponent();
            m_weinregal = new cls_Weinregal(this);
        }

        private void btn_WeingutVerwalten_Click(object sender, EventArgs e)
        {
            if(m_weinregal.m_wein.Menge <= 0)
            {
                dlg_WeingutVerwalten WeingutVerwalten = new dlg_WeingutVerwalten();
                WeingutVerwalten.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bitte den restlichen Wein einlagern.", "HINWEIS");
            }
            
        }

        private void btn_WeinEinlagern_Click(object sender, EventArgs e)
        {
            if (m_weinregal.m_wein.Menge <= 0)
            {
                dlg_WeinEinlagern einlagern = new dlg_WeinEinlagern();
                if (einlagern.ShowDialog() == DialogResult.OK)
                {
                    m_weinregal.m_eingelagert = false;
                    m_weinregal.m_vorhandenerWein = true;
                    if (m_weinregal.m_selectedWein != null)
                    {
                        if (m_weinregal.m_selectedWein.Tag.ToString() == "0")
                        {
                            cls_DataProvider.NeuerWein(einlagern.Wein);
                            m_weinregal.WeinEinlagern(einlagern.Wein.ID);
                            einlagern.Wein.Menge--;
                            if (einlagern.Wein.Menge > 0)
                            {
                                MessageBox.Show(String.Format("{0} Weine verbleibend.", einlagern.Wein.Menge), "HINWEIS");
                                m_weinregal.m_eingelagert = true;
                            }
                            else
                                MessageBox.Show("Wein wurde eingelagert.", "HINWEIS");
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
                    if (einlagern.Wein.Menge > 0)
                    {
                        m_weinregal.m_wein = einlagern.Wein;
                    }
                }
                else if(einlagern.DialogResult == DialogResult.Yes)
                {
                    m_weinregal.m_vorhandenerWein = false;
                    m_weinregal.m_eingelagert = true;
                    if (m_weinregal.m_selectedWein != null)
                    {
                        if (m_weinregal.m_selectedWein.Tag.ToString() == "0")
                        {
                            cls_DataProvider.VorhandenerWein(einlagern.Wein.Menge, einlagern.Wein.ID);
                            m_weinregal.WeinEinlagern(einlagern.Wein.ID);
                            einlagern.Wein.Menge--;
                            if (einlagern.Wein.Menge > 0)
                            {
                                MessageBox.Show(String.Format("{0} Weine verbleibend.", einlagern.Wein.Menge), "HINWEIS");
                                m_weinregal.m_vorhandenerWein = true;
                            }
                            else
                                MessageBox.Show("Wein wurde eingelagert.", "HINWEIS");
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
                    if (einlagern.Wein.Menge > 0)
                    {
                        m_weinregal.m_wein = einlagern.Wein;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte den restlichen Wein einlagern.", "HINWEIS");
            }
        }

        private void btn_WeinKonsumieren_Click(object sender, EventArgs e)
        {
            if (m_weinregal.m_wein.Menge <= 0)
            {
                if (m_weinregal.m_selectedWein != null)
                {
                    if (m_weinregal.m_selectedWein.Tag.ToString() != "0")
                    {
                        dlg_WeinKonsumieren konsumieren = new dlg_WeinKonsumieren(Convert.ToUInt32(m_weinregal.m_selectedWein.Tag));
                        if (konsumieren.ShowDialog() == DialogResult.OK)
                        {
                            m_weinregal.WeinKonsumieren();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte wähle ein Fach mit einer Flasche aus.", "HINWEIS");
                    }
                }
                else
                {
                    MessageBox.Show("Bitte wähle ein Fach aus.", "HINWEIS");
                }
            }
            else
            {
                MessageBox.Show("Bitte den restlichen Wein einlagern.", "HINWEIS");
            }
        }

        private void frm_Weinlager_Click(object sender, EventArgs e)
        {
            m_weinregal.KeinenWeinAuswaehlen();
        }

        private void btn_KonsumAnzeigen_Click(object sender, EventArgs e)
        {
            if (m_weinregal.m_wein.Menge <= 0)
            {
                dlg_Konsumanzeige anzeige = new dlg_Konsumanzeige();
                anzeige.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bitte den restlichen Wein einlagern.", "HINWEIS");
            }
        }
    }
}
