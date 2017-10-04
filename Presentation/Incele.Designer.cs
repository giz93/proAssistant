namespace Presentation
{
    partial class Incele
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
            this.dtp_BaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_BitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numUD_BeklenenSure = new System.Windows.Forms.NumericUpDown();
            this.txt_ProjeAdi = new System.Windows.Forms.TextBox();
            this.rtxt_Isintanimi = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Tamam = new System.Windows.Forms.Button();
            this.gb_Developer = new System.Windows.Forms.GroupBox();
            this.gb_Istek_Bug = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxt_Aciklama = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Istek_Bug = new System.Windows.Forms.ComboBox();
            this.btn_KabulEt = new System.Windows.Forms.Button();
            this.btn_Reddet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_BeklenenSure)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_Developer.SuspendLayout();
            this.gb_Istek_Bug.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_BaslamaTarihi
            // 
            this.dtp_BaslamaTarihi.Location = new System.Drawing.Point(131, 61);
            this.dtp_BaslamaTarihi.Name = "dtp_BaslamaTarihi";
            this.dtp_BaslamaTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtp_BaslamaTarihi.TabIndex = 0;
            // 
            // dtp_BitisTarihi
            // 
            this.dtp_BitisTarihi.Location = new System.Drawing.Point(454, 63);
            this.dtp_BitisTarihi.Name = "dtp_BitisTarihi";
            this.dtp_BitisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtp_BitisTarihi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proje Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "İşin Tanımı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Beklenen Saat:";
            // 
            // numUD_BeklenenSure
            // 
            this.numUD_BeklenenSure.Location = new System.Drawing.Point(337, 21);
            this.numUD_BeklenenSure.Name = "numUD_BeklenenSure";
            this.numUD_BeklenenSure.Size = new System.Drawing.Size(120, 22);
            this.numUD_BeklenenSure.TabIndex = 7;
            // 
            // txt_ProjeAdi
            // 
            this.txt_ProjeAdi.Location = new System.Drawing.Point(119, 61);
            this.txt_ProjeAdi.Name = "txt_ProjeAdi";
            this.txt_ProjeAdi.Size = new System.Drawing.Size(535, 22);
            this.txt_ProjeAdi.TabIndex = 8;
            // 
            // rtxt_Isintanimi
            // 
            this.rtxt_Isintanimi.Location = new System.Drawing.Point(119, 95);
            this.rtxt_Isintanimi.Name = "rtxt_Isintanimi";
            this.rtxt_Isintanimi.Size = new System.Drawing.Size(535, 180);
            this.rtxt_Isintanimi.TabIndex = 9;
            this.rtxt_Isintanimi.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rtxt_Isintanimi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ProjeAdi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 292);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje Hakkında";
            // 
            // btn_Tamam
            // 
            this.btn_Tamam.Location = new System.Drawing.Point(554, 662);
            this.btn_Tamam.Name = "btn_Tamam";
            this.btn_Tamam.Size = new System.Drawing.Size(90, 44);
            this.btn_Tamam.TabIndex = 11;
            this.btn_Tamam.Text = "Tamam";
            this.btn_Tamam.UseVisualStyleBackColor = true;
            this.btn_Tamam.Click += new System.EventHandler(this.btn_Tamam_Click);
            // 
            // gb_Developer
            // 
            this.gb_Developer.Controls.Add(this.label5);
            this.gb_Developer.Controls.Add(this.dtp_BaslamaTarihi);
            this.gb_Developer.Controls.Add(this.dtp_BitisTarihi);
            this.gb_Developer.Controls.Add(this.numUD_BeklenenSure);
            this.gb_Developer.Controls.Add(this.label1);
            this.gb_Developer.Controls.Add(this.label2);
            this.gb_Developer.Location = new System.Drawing.Point(0, 562);
            this.gb_Developer.Name = "gb_Developer";
            this.gb_Developer.Size = new System.Drawing.Size(676, 94);
            this.gb_Developer.TabIndex = 12;
            this.gb_Developer.TabStop = false;
            // 
            // gb_Istek_Bug
            // 
            this.gb_Istek_Bug.Controls.Add(this.label7);
            this.gb_Istek_Bug.Controls.Add(this.rtxt_Aciklama);
            this.gb_Istek_Bug.Controls.Add(this.label6);
            this.gb_Istek_Bug.Controls.Add(this.cb_Istek_Bug);
            this.gb_Istek_Bug.Location = new System.Drawing.Point(0, 298);
            this.gb_Istek_Bug.Name = "gb_Istek_Bug";
            this.gb_Istek_Bug.Size = new System.Drawing.Size(674, 258);
            this.gb_Istek_Bug.TabIndex = 13;
            this.gb_Istek_Bug.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Açıklama:";
            // 
            // rtxt_Aciklama
            // 
            this.rtxt_Aciklama.Location = new System.Drawing.Point(119, 69);
            this.rtxt_Aciklama.Name = "rtxt_Aciklama";
            this.rtxt_Aciklama.Size = new System.Drawing.Size(535, 180);
            this.rtxt_Aciklama.TabIndex = 10;
            this.rtxt_Aciklama.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "İşlem Türü:";
            // 
            // cb_Istek_Bug
            // 
            this.cb_Istek_Bug.FormattingEnabled = true;
            this.cb_Istek_Bug.Items.AddRange(new object[] {
            "İstek",
            "Bug"});
            this.cb_Istek_Bug.Location = new System.Drawing.Point(119, 21);
            this.cb_Istek_Bug.Name = "cb_Istek_Bug";
            this.cb_Istek_Bug.Size = new System.Drawing.Size(535, 24);
            this.cb_Istek_Bug.TabIndex = 0;
            // 
            // btn_KabulEt
            // 
            this.btn_KabulEt.Location = new System.Drawing.Point(296, 663);
            this.btn_KabulEt.Name = "btn_KabulEt";
            this.btn_KabulEt.Size = new System.Drawing.Size(152, 44);
            this.btn_KabulEt.TabIndex = 14;
            this.btn_KabulEt.Text = "Kabul Et ve Ata";
            this.btn_KabulEt.UseVisualStyleBackColor = true;
            this.btn_KabulEt.Click += new System.EventHandler(this.btn_KabulEt_Click);
            this.btn_KabulEt.Enter += new System.EventHandler(this.btn_KabulEt_Click);
            // 
            // btn_Reddet
            // 
            this.btn_Reddet.Location = new System.Drawing.Point(458, 663);
            this.btn_Reddet.Name = "btn_Reddet";
            this.btn_Reddet.Size = new System.Drawing.Size(90, 44);
            this.btn_Reddet.TabIndex = 15;
            this.btn_Reddet.Text = "Reddet";
            this.btn_Reddet.UseVisualStyleBackColor = true;
            this.btn_Reddet.Click += new System.EventHandler(this.btn_Reddet_Click);
            // 
            // Incele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 719);
            this.Controls.Add(this.btn_Reddet);
            this.Controls.Add(this.gb_Istek_Bug);
            this.Controls.Add(this.btn_KabulEt);
            this.Controls.Add(this.gb_Developer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Tamam);
            this.Name = "Incele";
            this.Text = "Incele";
            this.Load += new System.EventHandler(this.Incele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_BeklenenSure)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Developer.ResumeLayout(false);
            this.gb_Developer.PerformLayout();
            this.gb_Istek_Bug.ResumeLayout(false);
            this.gb_Istek_Bug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_BaslamaTarihi;
        private System.Windows.Forms.DateTimePicker dtp_BitisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUD_BeklenenSure;
        private System.Windows.Forms.TextBox txt_ProjeAdi;
        private System.Windows.Forms.RichTextBox rtxt_Isintanimi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Tamam;
        private System.Windows.Forms.GroupBox gb_Developer;
        private System.Windows.Forms.GroupBox gb_Istek_Bug;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxt_Aciklama;
        private System.Windows.Forms.ComboBox cb_Istek_Bug;
        private System.Windows.Forms.Button btn_Reddet;
        public System.Windows.Forms.Button btn_KabulEt;
    }
}