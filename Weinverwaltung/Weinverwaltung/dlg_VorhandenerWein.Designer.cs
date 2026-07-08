namespace Weinverwaltung
{
    partial class dlg_VorhandenerWein
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
            this.lbx_Weine = new System.Windows.Forms.ListBox();
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.btn_Auswaehlen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_Weine
            // 
            this.lbx_Weine.FormattingEnabled = true;
            this.lbx_Weine.ItemHeight = 16;
            this.lbx_Weine.Location = new System.Drawing.Point(12, 12);
            this.lbx_Weine.Name = "lbx_Weine";
            this.lbx_Weine.Size = new System.Drawing.Size(493, 356);
            this.lbx_Weine.TabIndex = 0;
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Zurueck.Location = new System.Drawing.Point(411, 374);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(94, 45);
            this.btn_Zurueck.TabIndex = 4;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            // 
            // btn_Auswaehlen
            // 
            this.btn_Auswaehlen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Auswaehlen.Location = new System.Drawing.Point(12, 374);
            this.btn_Auswaehlen.Name = "btn_Auswaehlen";
            this.btn_Auswaehlen.Size = new System.Drawing.Size(94, 45);
            this.btn_Auswaehlen.TabIndex = 5;
            this.btn_Auswaehlen.Text = "Auswählen";
            this.btn_Auswaehlen.UseVisualStyleBackColor = true;
            this.btn_Auswaehlen.Click += new System.EventHandler(this.btn_Auswaehlen_Click);
            // 
            // dlg_VorhandenerWein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Zurueck;
            this.ClientSize = new System.Drawing.Size(517, 436);
            this.Controls.Add(this.btn_Auswaehlen);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.lbx_Weine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlg_VorhandenerWein";
            this.ShowInTaskbar = false;
            this.Text = "Liste der Weine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Weine;
        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.Button btn_Auswaehlen;
    }
}