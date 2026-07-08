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
    public partial class dlg_Weingut : Form
    {
        uint m_id = 0;
        public cls_Weingut Weingut
        { get; set; }

        public dlg_Weingut()
        {
            InitializeComponent();
        }
        public dlg_Weingut(cls_Weingut weingut)
        {
            InitializeComponent();
            m_id = weingut.ID;
            tbx_Name.Text = weingut.Name;
            tbx_Strasse.Text = weingut.Strasse;
            tbx_PLZ.Text = weingut.PLZ;
            tbx_Ort.Text = weingut.Ort;
            tbx_EMail.Text = weingut.EMail;
            tbx_Telefon.Text = weingut.Telefon;
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            if (tbx_Name.Text == "" || tbx_Strasse.Text == "" || tbx_PLZ.Text == "" || tbx_Ort.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle erforderlichen (*) Felder aus!", "HINWEIS");
            }
            else
            {
                if (m_id > 0)
                    Weingut = new cls_Weingut(m_id, tbx_Name.Text, tbx_Strasse.Text, tbx_PLZ.Text, tbx_Ort.Text, tbx_EMail.Text, tbx_Telefon.Text);
                else
                    Weingut = new cls_Weingut(tbx_Name.Text, tbx_Strasse.Text, tbx_PLZ.Text, tbx_Ort.Text, tbx_EMail.Text, tbx_Telefon.Text);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
