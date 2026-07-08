namespace Weinverwaltung
{
    partial class dlg_Konsumanzeige
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
            this.btn_Zurueck = new System.Windows.Forms.Button();
            this.lbx_Konsum = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Zurueck
            // 
            this.btn_Zurueck.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Zurueck.Location = new System.Drawing.Point(461, 390);
            this.btn_Zurueck.Name = "btn_Zurueck";
            this.btn_Zurueck.Size = new System.Drawing.Size(94, 45);
            this.btn_Zurueck.TabIndex = 6;
            this.btn_Zurueck.Text = "Zurück";
            this.btn_Zurueck.UseVisualStyleBackColor = true;
            // 
            // lbx_Konsum
            // 
            this.lbx_Konsum.FormattingEnabled = true;
            this.lbx_Konsum.ItemHeight = 16;
            this.lbx_Konsum.Location = new System.Drawing.Point(12, 12);
            this.lbx_Konsum.Name = "lbx_Konsum";
            this.lbx_Konsum.Size = new System.Drawing.Size(543, 372);
            this.lbx_Konsum.TabIndex = 5;
            // 
            // dlg_Konsumanzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Zurueck;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btn_Zurueck);
            this.Controls.Add(this.lbx_Konsum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlg_Konsumanzeige";
            this.ShowInTaskbar = false;
            this.Text = "Konsumanzeige";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Zurueck;
        private System.Windows.Forms.ListBox lbx_Konsum;
    }
}