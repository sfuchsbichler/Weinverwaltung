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
    public partial class dlg_WeinKonsumieren : Form
    {
        uint m_id;
        public dlg_WeinKonsumieren()
        {
            InitializeComponent();
        }
        public dlg_WeinKonsumieren(uint id_wein)
        {
            InitializeComponent();
            m_id = id_wein;
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            cls_DataProvider.NotizAendern(rtb_Notiz.Text, m_id);
        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            rtb_Notiz.Text = "";
        }

        private void btn_NotizLaden_Click(object sender, EventArgs e)
        {
            rtb_Notiz.Text = cls_DataProvider.NotizAnzeigen(m_id);
            if(rtb_Notiz.Text == "")
            {
                MessageBox.Show("Es ist keine Notiz vorhanden.");
            }
        }
    }
}
