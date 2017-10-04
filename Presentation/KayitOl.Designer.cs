namespace Presentation
{
    partial class KayitOl
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
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_SifreTekrar = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(117, 250);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(309, 22);
            this.txt_Sifre.TabIndex = 1;
            // 
            // txt_SifreTekrar
            // 
            this.txt_SifreTekrar.Location = new System.Drawing.Point(117, 298);
            this.txt_SifreTekrar.Name = "txt_SifreTekrar";
            this.txt_SifreTekrar.PasswordChar = '*';
            this.txt_SifreTekrar.Size = new System.Drawing.Size(309, 22);
            this.txt_SifreTekrar.TabIndex = 2;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(311, 349);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(115, 44);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kayıt Ol";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre (Tekrar):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(138, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pro Assistant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-Posta:";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(117, 211);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(309, 22);
            this.txt_Mail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ad Soyad:";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(117, 169);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(309, 22);
            this.txt_AdSoyad.TabIndex = 12;
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_SifreTekrar);
            this.Controls.Add(this.txt_Sifre);
            this.Name = "KayitOl";
            this.Text = "KayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_SifreTekrar;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_AdSoyad;
    }
}