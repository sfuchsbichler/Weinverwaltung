namespace Weinverwaltung
{
    partial class dlg_WeinEinlagern
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
            this.cob_Sorte = new System.Windows.Forms.ComboBox();
            this.lbl_Sorte = new System.Windows.Forms.Label();
            this.cob_Weingut = new System.Windows.Forms.ComboBox();
            this.btn_Einlagern = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.nud_Menge = new System.Windows.Forms.NumericUpDown();
            this.nud_Einzelpreis = new System.Windows.Forms.NumericUpDown();
            this.nud_Liter = new System.Windows.Forms.NumericUpDown();
            this.nud_Jahrgang = new System.Windows.Forms.NumericUpDown();
            this.nud_Alkoholgehalt = new System.Windows.Forms.NumericUpDown();
            this.tbx_Bezeichnung = new System.Windows.Forms.TextBox();
            this.lbl_Weingut = new System.Windows.Forms.Label();
            this.lbl_Alkoholgehalt = new System.Windows.Forms.Label();
            this.lbl_Einzelpreis = new System.Windows.Forms.Label();
            this.lbl_Menge = new System.Windows.Forms.Label();
            this.lbl_Liter = new System.Windows.Forms.Label();
            this.lbl_Jahrgang = new System.Windows.Forms.Label();
            this.lbl_Bezeichnung = new System.Windows.Forms.Label();
            this.btn_VorhandenerWein = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Menge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Einzelpreis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Liter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Jahrgang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Alkoholgehalt)).BeginInit();
            this.SuspendLayout();
            // 
            // cob_Sorte
            // 
            this.cob_Sorte.FormattingEnabled = true;
            this.cob_Sorte.Location = new System.Drawing.Point(205, 65);
            this.cob_Sorte.Name = "cob_Sorte";
            this.cob_Sorte.Size = new System.Drawing.Size(314, 24);
            this.cob_Sorte.TabIndex = 35;
            // 
            // lbl_Sorte
            // 
            this.lbl_Sorte.AutoSize = true;
            this.lbl_Sorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sorte.Location = new System.Drawing.Point(25, 65);
            this.lbl_Sorte.Name = "lbl_Sorte";
            this.lbl_Sorte.Size = new System.Drawing.Size(54, 20);
            this.lbl_Sorte.TabIndex = 34;
            this.lbl_Sorte.Text = "Sorte:";
            // 
            // cob_Weingut
            // 
            this.cob_Weingut.FormattingEnabled = true;
            this.cob_Weingut.Location = new System.Drawing.Point(205, 305);
            this.cob_Weingut.Name = "cob_Weingut";
            this.cob_Weingut.Size = new System.Drawing.Size(314, 24);
            this.cob_Weingut.TabIndex = 33;
            // 
            // btn_Einlagern
            // 
            this.btn_Einlagern.Location = new System.Drawing.Point(29, 354);
            this.btn_Einlagern.Name = "btn_Einlagern";
            this.btn_Einlagern.Size = new System.Drawing.Size(103, 43);
            this.btn_Einlagern.TabIndex = 32;
            this.btn_Einlagern.Text = "Einlagern";
            this.btn_Einlagern.UseVisualStyleBackColor = true;
            this.btn_Einlagern.Click += new System.EventHandler(this.btn_Einlagern_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Abbrechen.Location = new System.Drawing.Point(416, 354);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(103, 43);
            this.btn_Abbrechen.TabIndex = 31;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // nud_Menge
            // 
            this.nud_Menge.Location = new System.Drawing.Point(205, 266);
            this.nud_Menge.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Menge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Menge.Name = "nud_Menge";
            this.nud_Menge.Size = new System.Drawing.Size(170, 22);
            this.nud_Menge.TabIndex = 30;
            this.nud_Menge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_Einzelpreis
            // 
            this.nud_Einzelpreis.DecimalPlaces = 2;
            this.nud_Einzelpreis.Location = new System.Drawing.Point(205, 226);
            this.nud_Einzelpreis.Name = "nud_Einzelpreis";
            this.nud_Einzelpreis.Size = new System.Drawing.Size(170, 22);
            this.nud_Einzelpreis.TabIndex = 29;
            // 
            // nud_Liter
            // 
            this.nud_Liter.DecimalPlaces = 2;
            this.nud_Liter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_Liter.Location = new System.Drawing.Point(205, 186);
            this.nud_Liter.Name = "nud_Liter";
            this.nud_Liter.Size = new System.Drawing.Size(170, 22);
            this.nud_Liter.TabIndex = 28;
            // 
            // nud_Jahrgang
            // 
            this.nud_Jahrgang.Location = new System.Drawing.Point(205, 146);
            this.nud_Jahrgang.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nud_Jahrgang.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_Jahrgang.Name = "nud_Jahrgang";
            this.nud_Jahrgang.Size = new System.Drawing.Size(170, 22);
            this.nud_Jahrgang.TabIndex = 27;
            this.nud_Jahrgang.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nud_Alkoholgehalt
            // 
            this.nud_Alkoholgehalt.DecimalPlaces = 3;
            this.nud_Alkoholgehalt.Location = new System.Drawing.Point(205, 106);
            this.nud_Alkoholgehalt.Name = "nud_Alkoholgehalt";
            this.nud_Alkoholgehalt.Size = new System.Drawing.Size(170, 22);
            this.nud_Alkoholgehalt.TabIndex = 26;
            // 
            // tbx_Bezeichnung
            // 
            this.tbx_Bezeichnung.Location = new System.Drawing.Point(205, 25);
            this.tbx_Bezeichnung.Name = "tbx_Bezeichnung";
            this.tbx_Bezeichnung.Size = new System.Drawing.Size(314, 22);
            this.tbx_Bezeichnung.TabIndex = 25;
            // 
            // lbl_Weingut
            // 
            this.lbl_Weingut.AutoSize = true;
            this.lbl_Weingut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weingut.Location = new System.Drawing.Point(25, 305);
            this.lbl_Weingut.Name = "lbl_Weingut";
            this.lbl_Weingut.Size = new System.Drawing.Size(75, 20);
            this.lbl_Weingut.TabIndex = 24;
            this.lbl_Weingut.Text = "Weingut:";
            // 
            // lbl_Alkoholgehalt
            // 
            this.lbl_Alkoholgehalt.AutoSize = true;
            this.lbl_Alkoholgehalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alkoholgehalt.Location = new System.Drawing.Point(25, 105);
            this.lbl_Alkoholgehalt.Name = "lbl_Alkoholgehalt";
            this.lbl_Alkoholgehalt.Size = new System.Drawing.Size(151, 20);
            this.lbl_Alkoholgehalt.TabIndex = 23;
            this.lbl_Alkoholgehalt.Text = "Alkoholgehalt in %:";
            // 
            // lbl_Einzelpreis
            // 
            this.lbl_Einzelpreis.AutoSize = true;
            this.lbl_Einzelpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Einzelpreis.Location = new System.Drawing.Point(25, 225);
            this.lbl_Einzelpreis.Name = "lbl_Einzelpreis";
            this.lbl_Einzelpreis.Size = new System.Drawing.Size(97, 20);
            this.lbl_Einzelpreis.TabIndex = 22;
            this.lbl_Einzelpreis.Text = "Einzelpreis:";
            // 
            // lbl_Menge
            // 
            this.lbl_Menge.AutoSize = true;
            this.lbl_Menge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menge.Location = new System.Drawing.Point(25, 265);
            this.lbl_Menge.Name = "lbl_Menge";
            this.lbl_Menge.Size = new System.Drawing.Size(64, 20);
            this.lbl_Menge.TabIndex = 21;
            this.lbl_Menge.Text = "Menge:";
            // 
            // lbl_Liter
            // 
            this.lbl_Liter.AutoSize = true;
            this.lbl_Liter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Liter.Location = new System.Drawing.Point(25, 185);
            this.lbl_Liter.Name = "lbl_Liter";
            this.lbl_Liter.Size = new System.Drawing.Size(48, 20);
            this.lbl_Liter.TabIndex = 20;
            this.lbl_Liter.Text = "Liter:";
            // 
            // lbl_Jahrgang
            // 
            this.lbl_Jahrgang.AutoSize = true;
            this.lbl_Jahrgang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jahrgang.Location = new System.Drawing.Point(25, 145);
            this.lbl_Jahrgang.Name = "lbl_Jahrgang";
            this.lbl_Jahrgang.Size = new System.Drawing.Size(83, 20);
            this.lbl_Jahrgang.TabIndex = 19;
            this.lbl_Jahrgang.Text = "Jahrgang:";
            // 
            // lbl_Bezeichnung
            // 
            this.lbl_Bezeichnung.AutoSize = true;
            this.lbl_Bezeichnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bezeichnung.Location = new System.Drawing.Point(25, 25);
            this.lbl_Bezeichnung.Name = "lbl_Bezeichnung";
            this.lbl_Bezeichnung.Size = new System.Drawing.Size(111, 20);
            this.lbl_Bezeichnung.TabIndex = 18;
            this.lbl_Bezeichnung.Text = "Bezeichnung:";
            // 
            // btn_VorhandenerWein
            // 
            this.btn_VorhandenerWein.Location = new System.Drawing.Point(216, 354);
            this.btn_VorhandenerWein.Name = "btn_VorhandenerWein";
            this.btn_VorhandenerWein.Size = new System.Drawing.Size(113, 43);
            this.btn_VorhandenerWein.TabIndex = 38;
            this.btn_VorhandenerWein.Text = "vorhandenen Wein auswählen";
            this.btn_VorhandenerWein.UseVisualStyleBackColor = true;
            this.btn_VorhandenerWein.Click += new System.EventHandler(this.btn_VorhandenerWein_Click);
            // 
            // dlg_WeinEinlagern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Abbrechen;
            this.ClientSize = new System.Drawing.Size(544, 421);
            this.Controls.Add(this.btn_VorhandenerWein);
            this.Controls.Add(this.cob_Sorte);
            this.Controls.Add(this.lbl_Sorte);
            this.Controls.Add(this.cob_Weingut);
            this.Controls.Add(this.btn_Einlagern);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.nud_Menge);
            this.Controls.Add(this.nud_Einzelpreis);
            this.Controls.Add(this.nud_Liter);
            this.Controls.Add(this.nud_Jahrgang);
            this.Controls.Add(this.nud_Alkoholgehalt);
            this.Controls.Add(this.tbx_Bezeichnung);
            this.Controls.Add(this.lbl_Weingut);
            this.Controls.Add(this.lbl_Alkoholgehalt);
            this.Controls.Add(this.lbl_Einzelpreis);
            this.Controls.Add(this.lbl_Menge);
            this.Controls.Add(this.lbl_Liter);
            this.Controls.Add(this.lbl_Jahrgang);
            this.Controls.Add(this.lbl_Bezeichnung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlg_WeinEinlagern";
            this.ShowInTaskbar = false;
            this.Text = "Wein einlagern";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Menge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Einzelpreis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Liter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Jahrgang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Alkoholgehalt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cob_Sorte;
        private System.Windows.Forms.Label lbl_Sorte;
        private System.Windows.Forms.ComboBox cob_Weingut;
        private System.Windows.Forms.Button btn_Einlagern;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.NumericUpDown nud_Menge;
        private System.Windows.Forms.NumericUpDown nud_Einzelpreis;
        private System.Windows.Forms.NumericUpDown nud_Liter;
        private System.Windows.Forms.NumericUpDown nud_Jahrgang;
        private System.Windows.Forms.NumericUpDown nud_Alkoholgehalt;
        private System.Windows.Forms.TextBox tbx_Bezeichnung;
        private System.Windows.Forms.Label lbl_Weingut;
        private System.Windows.Forms.Label lbl_Alkoholgehalt;
        private System.Windows.Forms.Label lbl_Einzelpreis;
        private System.Windows.Forms.Label lbl_Menge;
        private System.Windows.Forms.Label lbl_Liter;
        private System.Windows.Forms.Label lbl_Jahrgang;
        private System.Windows.Forms.Label lbl_Bezeichnung;
        private System.Windows.Forms.Button btn_VorhandenerWein;
    }
}