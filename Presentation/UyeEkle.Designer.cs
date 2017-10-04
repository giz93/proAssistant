namespace Presentation
{
    partial class UyeEkle
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.lbl_Kadi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ad Soyad:";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(150, 122);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(309, 22);
            this.txt_AdSoyad.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-Posta:";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(150, 164);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(309, 22);
            this.txt_Mail.TabIndex = 14;
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(361, 31);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(41, 17);
            this.lbl_Tarih.TabIndex = 20;
            this.lbl_Tarih.Text = "Tarih";
            // 
            // lbl_Kadi
            // 
            this.lbl_Kadi.AutoSize = true;
            this.lbl_Kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kadi.Location = new System.Drawing.Point(254, 61);
            this.lbl_Kadi.Name = "lbl_Kadi";
            this.lbl_Kadi.Size = new System.Drawing.Size(148, 25);
            this.lbl_Kadi.TabIndex = 19;
            this.lbl_Kadi.Text = "Merhaba User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pro Assistant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Üye Türü:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Developer",
            "Müşteri"});
            this.comboBox1.Location = new System.Drawing.Point(150, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(344, 259);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(115, 44);
            this.btn_Kaydet.TabIndex = 23;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 383);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.lbl_Kadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Mail);
            this.Name = "UyeEkle";
            this.Text = "UyeEkle";
            this.Load += new System.EventHandler(this.UyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Label lbl_Kadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}