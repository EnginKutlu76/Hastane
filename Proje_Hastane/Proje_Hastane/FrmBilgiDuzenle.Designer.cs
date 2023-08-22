namespace Proje_Hastane
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.btnBilgiDüzenle = new System.Windows.Forms.Button();
            this.cmbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTCKayit = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifreKayit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilgiDüzenle
            // 
            this.btnBilgiDüzenle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBilgiDüzenle.Location = new System.Drawing.Point(171, 369);
            this.btnBilgiDüzenle.Name = "btnBilgiDüzenle";
            this.btnBilgiDüzenle.Size = new System.Drawing.Size(173, 51);
            this.btnBilgiDüzenle.TabIndex = 7;
            this.btnBilgiDüzenle.Text = "Güncelle";
            this.btnBilgiDüzenle.UseVisualStyleBackColor = false;
            this.btnBilgiDüzenle.Click += new System.EventHandler(this.btnBilgiDüzenle_Click);
            // 
            // cmbxCinsiyet
            // 
            this.cmbxCinsiyet.FormattingEnabled = true;
            this.cmbxCinsiyet.Items.AddRange(new object[] {
            "Erkek\t",
            "Kadın"});
            this.cmbxCinsiyet.Location = new System.Drawing.Point(171, 318);
            this.cmbxCinsiyet.Name = "cmbxCinsiyet";
            this.cmbxCinsiyet.Size = new System.Drawing.Size(173, 36);
            this.cmbxCinsiyet.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(171, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(173, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // mskTCKayit
            // 
            this.mskTCKayit.Location = new System.Drawing.Point(171, 147);
            this.mskTCKayit.Mask = "00000000000";
            this.mskTCKayit.Name = "mskTCKayit";
            this.mskTCKayit.Size = new System.Drawing.Size(173, 36);
            this.mskTCKayit.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cinsiyet:";
            // 
            // txtSifreKayit
            // 
            this.txtSifreKayit.Location = new System.Drawing.Point(171, 259);
            this.txtSifreKayit.Name = "txtSifreKayit";
            this.txtSifreKayit.Size = new System.Drawing.Size(173, 36);
            this.txtSifreKayit.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefon No:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(171, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(173, 36);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Soyad:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(171, 200);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(173, 36);
            this.MskTelefon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.btnBilgiDüzenle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(371, 431);
            this.Controls.Add(this.btnBilgiDüzenle);
            this.Controls.Add(this.cmbxCinsiyet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.mskTCKayit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSifreKayit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBilgiDuzenle";
            this.Text = "FrmBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiDüzenle;
        private System.Windows.Forms.ComboBox cmbxCinsiyet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTCKayit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifreKayit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}