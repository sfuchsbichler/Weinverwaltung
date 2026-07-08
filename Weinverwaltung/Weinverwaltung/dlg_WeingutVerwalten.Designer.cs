namespace Weinverwaltung
{
    partial class dlg_WeingutVerwalten
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Neu = new System.Windows.Forms.Button();
            this.btn_Aendern = new System.Windows.Forms.Button();
            this.btn_Loeschen = new System.Windows.Forms.Button();
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.lbx_Weingueter = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Neu
            // 
            this.btn_Neu.Location = new System.Drawing.Point(12, 480);
            this.btn_Neu.Name = "btn_Neu";
            this.btn_Neu.Size = new System.Drawing.Size(94, 45);
            this.btn_Neu.TabIndex = 0;
            this.btn_Neu.Text = "Neu";
            this.btn_Neu.UseVisualStyleBackColor = true;
            this.btn_Neu.Click += new System.EventHandler(this.btn_Neu_Click);
            // 
            // btn_Aendern
            // 
            this.btn_Aendern.Location = new System.Drawing.Point(112, 480);
            this.btn_Aendern.Name = "btn_Aendern";
            this.btn_Aendern.Size = new System.Drawing.Size(94, 45);
            this.btn_Aendern.TabIndex = 1;
            this.btn_Aendern.Text = "Ändern";
            this.btn_Aendern.UseVisualStyleBackColor = true;
            this.btn_Aendern.Click += new System.EventHandler(this.btn_Aendern_Click);
            // 
            // btn_Loeschen
            // 
            this.btn_Loeschen.Location = new System.Drawing.Point(212, 480);
            this.btn_Loeschen.Name = "btn_Loeschen";
            this.btn_Loeschen.Size = new System.Drawing.Size(94, 45);
            this.btn_Loeschen.TabIndex = 2;
            this.btn_Loeschen.Text = "Löschen";
            this.btn_Loeschen.UseVisualStyleBackColor = true;
            this.btn_Loeschen.Click += new System.EventHandler(this.btn_Loeschen_Click);
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Zurueck.Location = new System.Drawing.Point(312, 480);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(94, 45);
            this.btn_Zurueck.TabIndex = 3;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            // 
            // lbx_Weingueter
            // 
            this.lbx_Weingueter.FormattingEnabled = true;
            this.lbx_Weingueter.ItemHeight = 16;
            this.lbx_Weingueter.Location = new System.Drawing.Point(12, 12);
            this.lbx_Weingueter.Name = "lbx_Weingueter";
            this.lbx_Weingueter.Size = new System.Drawing.Size(394, 452);
            this.lbx_Weingueter.TabIndex = 4;
            this.lbx_Weingueter.DoubleClick += new System.EventHandler(this.lbx_Weingueter_DoubleClick);
            // 
            // dlg_WeingutVerwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Zurueck;
            this.ClientSize = new System.Drawing.Size(418, 537);
            this.Controls.Add(this.lbx_Weingueter);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.btn_Loeschen);
            this.Controls.Add(this.btn_Aendern);
            this.Controls.Add(this.btn_Neu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlg_WeingutVerwalten";
            this.ShowInTaskbar = false;
            this.Text = "Weingüter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Neu;
        private System.Windows.Forms.Button btn_Aendern;
        private System.Windows.Forms.Button btn_Loeschen;
        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.ListBox lbx_Weingueter;
    }
}