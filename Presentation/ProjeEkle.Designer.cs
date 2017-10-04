namespace Presentation
{
    partial class ProjeEkle
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
            this.lbl_Kadi = new System.Windows.Forms.Label();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_IsTanimi = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ProjeAdi = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxt_Aciklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pro Assistant";
            // 
            // lbl_Kadi
            // 
            this.lbl_Kadi.AutoSize = true;
            this.lbl_Kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kadi.Location = new System.Drawing.Point(410, 61);
            this.lbl_Kadi.Name = "lbl_Kadi";
            this.lbl_Kadi.Size = new System.Drawing.Size(148, 25);
            this.lbl_Kadi.TabIndex = 3;
            this.lbl_Kadi.Text = "Merhaba User";
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(580, 32);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(41, 17);
            this.lbl_Tarih.TabIndex = 4;
            this.lbl_Tarih.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Proje Adı:";
            // 
            // rtxt_IsTanimi
            // 
            this.rtxt_IsTanimi.Location = new System.Drawing.Point(131, 185);
            this.rtxt_IsTanimi.Name = "rtxt_IsTanimi";
            this.rtxt_IsTanimi.Size = new System.Drawing.Size(535, 180);
            this.rtxt_IsTanimi.TabIndex = 13;
            this.rtxt_IsTanimi.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "İşin Tanımı:";
            // 
            // txt_ProjeAdi
            // 
            this.txt_ProjeAdi.Location = new System.Drawing.Point(131, 151);
            this.txt_ProjeAdi.Name = "txt_ProjeAdi";
            this.txt_ProjeAdi.Size = new System.Drawing.Size(535, 22);
            this.txt_ProjeAdi.TabIndex = 12;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(566, 707);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(100, 36);
            this.btn_Ekle.TabIndex = 16;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "İşlem Türü:";
            // 
            // rtxt_Aciklama
            // 
            this.rtxt_Aciklama.Location = new System.Drawing.Point(131, 439);
            this.rtxt_Aciklama.Name = "rtxt_Aciklama";
            this.rtxt_Aciklama.Size = new System.Drawing.Size(535, 180);
            this.rtxt_Aciklama.TabIndex = 20;
            this.rtxt_Aciklama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Açıklama";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İstek",
            "Bug"});
            this.comboBox1.Location = new System.Drawing.Point(131, 408);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(535, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // ProjeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 768);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxt_Aciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxt_IsTanimi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ProjeAdi);
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.lbl_Kadi);
            this.Controls.Add(this.label6);
            this.Name = "ProjeEkle";
            this.Text = "ProjeEkle";
            this.Load += new System.EventHandler(this.ProjeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Kadi;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_IsTanimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ProjeAdi;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxt_Aciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}