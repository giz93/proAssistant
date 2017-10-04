namespace Presentation
{
    partial class Giris
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
            this.txt_KAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_KayitOl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_KAdi
            // 
            this.txt_KAdi.Location = new System.Drawing.Point(113, 135);
            this.txt_KAdi.Name = "txt_KAdi";
            this.txt_KAdi.Size = new System.Drawing.Size(273, 22);
            this.txt_KAdi.TabIndex = 0;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(113, 187);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(273, 22);
            this.txt_Sifre.TabIndex = 1;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(276, 226);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(110, 48);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            this.btn_Giris.Enter += new System.EventHandler(this.btn_Giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(108, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pro Assistant";
            // 
            // lbl_KayitOl
            // 
            this.lbl_KayitOl.AutoSize = true;
            this.lbl_KayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KayitOl.ForeColor = System.Drawing.Color.Blue;
            this.lbl_KayitOl.Location = new System.Drawing.Point(167, 381);
            this.lbl_KayitOl.Name = "lbl_KayitOl";
            this.lbl_KayitOl.Size = new System.Drawing.Size(65, 17);
            this.lbl_KayitOl.TabIndex = 6;
            this.lbl_KayitOl.Text = "Kayıt Ol";
            this.lbl_KayitOl.Click += new System.EventHandler(this.lbl_KayitOl_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 407);
            this.Controls.Add(this.lbl_KayitOl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KAdi);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_KayitOl;
    }
}