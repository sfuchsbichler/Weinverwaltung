namespace Weinverwaltung
{
    partial class frm_Weinlager
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_KonsumAnzeigen = new System.Windows.Forms.Button();
            this.btn_WeinEinlagern = new System.Windows.Forms.Button();
            this.btn_WeinKonsumieren = new System.Windows.Forms.Button();
            this.btn_WeingutVerwalten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_KonsumAnzeigen
            // 
            this.btn_KonsumAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KonsumAnzeigen.Location = new System.Drawing.Point(667, 445);
            this.btn_KonsumAnzeigen.Name = "btn_KonsumAnzeigen";
            this.btn_KonsumAnzeigen.Size = new System.Drawing.Size(151, 56);
            this.btn_KonsumAnzeigen.TabIndex = 2;
            this.btn_KonsumAnzeigen.Text = "Konsum anzeigen";
            this.btn_KonsumAnzeigen.UseVisualStyleBackColor = true;
            this.btn_KonsumAnzeigen.Click += new System.EventHandler(this.btn_KonsumAnzeigen_Click);
            // 
            // btn_WeinEinlagern
            // 
            this.btn_WeinEinlagern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WeinEinlagern.Location = new System.Drawing.Point(667, 383);
            this.btn_WeinEinlagern.Name = "btn_WeinEinlagern";
            this.btn_WeinEinlagern.Size = new System.Drawing.Size(151, 56);
            this.btn_WeinEinlagern.TabIndex = 3;
            this.btn_WeinEinlagern.Text = "Wein einlagern";
            this.btn_WeinEinlagern.UseVisualStyleBackColor = true;
            this.btn_WeinEinlagern.Click += new System.EventHandler(this.btn_WeinEinlagern_Click);
            // 
            // btn_WeinKonsumieren
            // 
            this.btn_WeinKonsumieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WeinKonsumieren.Location = new System.Drawing.Point(667, 321);
            this.btn_WeinKonsumieren.Name = "btn_WeinKonsumieren";
            this.btn_WeinKonsumieren.Size = new System.Drawing.Size(151, 56);
            this.btn_WeinKonsumieren.TabIndex = 4;
            this.btn_WeinKonsumieren.Text = "Wein konsumieren";
            this.btn_WeinKonsumieren.UseVisualStyleBackColor = true;
            this.btn_WeinKonsumieren.Click += new System.EventHandler(this.btn_WeinKonsumieren_Click);
            // 
            // btn_WeingutVerwalten
            // 
            this.btn_WeingutVerwalten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WeingutVerwalten.Location = new System.Drawing.Point(667, 259);
            this.btn_WeingutVerwalten.Name = "btn_WeingutVerwalten";
            this.btn_WeingutVerwalten.Size = new System.Drawing.Size(151, 56);
            this.btn_WeingutVerwalten.TabIndex = 6;
            this.btn_WeingutVerwalten.Text = "Weingüter verwalten";
            this.btn_WeingutVerwalten.UseVisualStyleBackColor = true;
            this.btn_WeingutVerwalten.Click += new System.EventHandler(this.btn_WeingutVerwalten_Click);
            // 
            // frm_Weinlager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 545);
            this.Controls.Add(this.btn_WeingutVerwalten);
            this.Controls.Add(this.btn_WeinKonsumieren);
            this.Controls.Add(this.btn_WeinEinlagern);
            this.Controls.Add(this.btn_KonsumAnzeigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Weinlager";
            this.Text = "Weinlager";
            this.Click += new System.EventHandler(this.frm_Weinlager_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_KonsumAnzeigen;
        private System.Windows.Forms.Button btn_WeinEinlagern;
        private System.Windows.Forms.Button btn_WeinKonsumieren;
        private System.Windows.Forms.Button btn_WeingutVerwalten;
    }
}

