namespace Weinverwaltung
{
    partial class dlg_Weingut
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
            this.tbx_Telefon = new System.Windows.Forms.TextBox();
            this.tbx_EMail = new System.Windows.Forms.TextBox();
            this.tbx_Ort = new System.Windows.Forms.TextBox();
            this.tbx_PLZ = new System.Windows.Forms.TextBox();
            this.tbx_Strasse = new System.Windows.Forms.TextBox();
            this.lbl_Strasse = new System.Windows.Forms.Label();
            this.btn_Speichern = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_PLZ = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_EMail = new System.Windows.Forms.Label();
            this.lbl_Ort = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_Telefon
            // 
            this.tbx_Telefon.Location = new System.Drawing.Point(122, 230);
            this.tbx_Telefon.Name = "tbx_Telefon";
            this.tbx_Telefon.Size = new System.Drawing.Size(314, 22);
            this.tbx_Telefon.TabIndex = 54;
            // 
            // tbx_EMail
            // 
            this.tbx_EMail.Location = new System.Drawing.Point(122, 190);
            this.tbx_EMail.Name = "tbx_EMail";
            this.tbx_EMail.Size = new System.Drawing.Size(314, 22);
            this.tbx_EMail.TabIndex = 53;
            // 
            // tbx_Ort
            // 
            this.tbx_Ort.Location = new System.Drawing.Point(122, 150);
            this.tbx_Ort.Name = "tbx_Ort";
            this.tbx_Ort.Size = new System.Drawing.Size(314, 22);
            this.tbx_Ort.TabIndex = 52;
            // 
            // tbx_PLZ
            // 
            this.tbx_PLZ.Location = new System.Drawing.Point(122, 110);
            this.tbx_PLZ.Name = "tbx_PLZ";
            this.tbx_PLZ.Size = new System.Drawing.Size(314, 22);
            this.tbx_PLZ.TabIndex = 51;
            // 
            // tbx_Strasse
            // 
            this.tbx_Strasse.Location = new System.Drawing.Point(122, 70);
            this.tbx_Strasse.Name = "tbx_Strasse";
            this.tbx_Strasse.Size = new System.Drawing.Size(314, 22);
            this.tbx_Strasse.TabIndex = 50;
            // 
            // lbl_Strasse
            // 
            this.lbl_Strasse.AutoSize = true;
            this.lbl_Strasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Strasse.Location = new System.Drawing.Point(30, 70);
            this.lbl_Strasse.Name = "lbl_Strasse";
            this.lbl_Strasse.Size = new System.Drawing.Size(75, 20);
            this.lbl_Strasse.TabIndex = 49;
            this.lbl_Strasse.Text = "Straße: *";
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Location = new System.Drawing.Point(34, 273);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(103, 43);
            this.btn_Speichern.TabIndex = 48;
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.UseVisualStyleBackColor = true;
            this.btn_Speichern.Click += new System.EventHandler(this.btn_Speichern_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Abbrechen.Location = new System.Drawing.Point(333, 273);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(103, 43);
            this.btn_Abbrechen.TabIndex = 47;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(122, 30);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(314, 22);
            this.tbx_Name.TabIndex = 46;
            // 
            // lbl_PLZ
            // 
            this.lbl_PLZ.AutoSize = true;
            this.lbl_PLZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PLZ.Location = new System.Drawing.Point(30, 110);
            this.lbl_PLZ.Name = "lbl_PLZ";
            this.lbl_PLZ.Size = new System.Drawing.Size(55, 20);
            this.lbl_PLZ.TabIndex = 45;
            this.lbl_PLZ.Text = "PLZ: *";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefon.Location = new System.Drawing.Point(30, 230);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(69, 20);
            this.lbl_Telefon.TabIndex = 44;
            this.lbl_Telefon.Text = "Telefon:";
            // 
            // lbl_EMail
            // 
            this.lbl_EMail.AutoSize = true;
            this.lbl_EMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EMail.Location = new System.Drawing.Point(30, 190);
            this.lbl_EMail.Name = "lbl_EMail";
            this.lbl_EMail.Size = new System.Drawing.Size(62, 20);
            this.lbl_EMail.TabIndex = 43;
            this.lbl_EMail.Text = "E-Mail:";
            // 
            // lbl_Ort
            // 
            this.lbl_Ort.AutoSize = true;
            this.lbl_Ort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ort.Location = new System.Drawing.Point(30, 150);
            this.lbl_Ort.Name = "lbl_Ort";
            this.lbl_Ort.Size = new System.Drawing.Size(49, 20);
            this.lbl_Ort.TabIndex = 42;
            this.lbl_Ort.Text = "Ort: *";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(30, 30);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(69, 20);
            this.lbl_Name.TabIndex = 41;
            this.lbl_Name.Text = "Name: *";
            // 
            // dlg_Weingut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Abbrechen;
            this.ClientSize = new System.Drawing.Size(465, 344);
            this.Controls.Add(this.tbx_Telefon);
            this.Controls.Add(this.tbx_EMail);
            this.Controls.Add(this.tbx_Ort);
            this.Controls.Add(this.tbx_PLZ);
            this.Controls.Add(this.tbx_Strasse);
            this.Controls.Add(this.lbl_Strasse);
            this.Controls.Add(this.btn_Speichern);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.lbl_PLZ);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.lbl_EMail);
            this.Controls.Add(this.lbl_Ort);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlg_Weingut";
            this.ShowInTaskbar = false;
            this.Text = "Weingut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Telefon;
        private System.Windows.Forms.TextBox tbx_EMail;
        private System.Windows.Forms.TextBox tbx_Ort;
        private System.Windows.Forms.TextBox tbx_PLZ;
        private System.Windows.Forms.TextBox tbx_Strasse;
        private System.Windows.Forms.Label lbl_Strasse;
        private System.Windows.Forms.Button btn_Speichern;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lbl_PLZ;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_EMail;
        private System.Windows.Forms.Label lbl_Ort;
        private System.Windows.Forms.Label lbl_Name;
    }
}