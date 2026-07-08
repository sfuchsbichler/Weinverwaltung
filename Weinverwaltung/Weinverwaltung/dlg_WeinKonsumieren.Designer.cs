namespace Weinverwaltung
{
    partial class dlg_WeinKonsumieren
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
            this.rtb_Notiz = new System.Windows.Forms.RichTextBox();
            this.lbl_Notiz = new System.Windows.Forms.Label();
            this.btn_Speichern = new System.Windows.Forms.Button();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.btn_NotizLaden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_Notiz
            // 
            this.rtb_Notiz.Location = new System.Drawing.Point(12, 42);
            this.rtb_Notiz.Name = "rtb_Notiz";
            this.rtb_Notiz.Size = new System.Drawing.Size(449, 293);
            this.rtb_Notiz.TabIndex = 0;
            this.rtb_Notiz.Text = "";
            // 
            // lbl_Notiz
            // 
            this.lbl_Notiz.AutoSize = true;
            this.lbl_Notiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notiz.Location = new System.Drawing.Point(12, 19);
            this.lbl_Notiz.Name = "lbl_Notiz";
            this.lbl_Notiz.Size = new System.Drawing.Size(53, 20);
            this.lbl_Notiz.TabIndex = 42;
            this.lbl_Notiz.Text = "Notiz:";
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Speichern.Location = new System.Drawing.Point(12, 350);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(103, 43);
            this.btn_Speichern.TabIndex = 49;
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.UseVisualStyleBackColor = true;
            this.btn_Speichern.Click += new System.EventHandler(this.btn_Speichern_Click);
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.Location = new System.Drawing.Point(185, 350);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(103, 43);
            this.btn_loeschen.TabIndex = 50;
            this.btn_loeschen.Text = "Text löschen";
            this.btn_loeschen.UseVisualStyleBackColor = true;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // btn_NotizLaden
            // 
            this.btn_NotizLaden.Location = new System.Drawing.Point(358, 350);
            this.btn_NotizLaden.Name = "btn_NotizLaden";
            this.btn_NotizLaden.Size = new System.Drawing.Size(103, 43);
            this.btn_NotizLaden.TabIndex = 51;
            this.btn_NotizLaden.Text = "vorhandene Notiz laden";
            this.btn_NotizLaden.UseVisualStyleBackColor = true;
            this.btn_NotizLaden.Click += new System.EventHandler(this.btn_NotizLaden_Click);
            // 
            // dlg_WeinKonsumieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 426);
            this.Controls.Add(this.btn_NotizLaden);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.btn_Speichern);
            this.Controls.Add(this.lbl_Notiz);
            this.Controls.Add(this.rtb_Notiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlg_WeinKonsumieren";
            this.ShowInTaskbar = false;
            this.Text = "Notiz eintragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Notiz;
        private System.Windows.Forms.Label lbl_Notiz;
        private System.Windows.Forms.Button btn_Speichern;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Button btn_NotizLaden;
    }
}