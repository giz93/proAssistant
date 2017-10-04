namespace Presentation
{
    partial class BitisOnay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_Aciklama = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ProjeAdi = new System.Windows.Forms.TextBox();
            this.btn_Bitir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rtxt_Aciklama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ProjeAdi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 321);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje Hakkında";
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
            // rtxt_Aciklama
            // 
            this.rtxt_Aciklama.Location = new System.Drawing.Point(119, 105);
            this.rtxt_Aciklama.Name = "rtxt_Aciklama";
            this.rtxt_Aciklama.Size = new System.Drawing.Size(535, 180);
            this.rtxt_Aciklama.TabIndex = 9;
            this.rtxt_Aciklama.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Açıklama:";
            // 
            // txt_ProjeAdi
            // 
            this.txt_ProjeAdi.Location = new System.Drawing.Point(119, 61);
            this.txt_ProjeAdi.Name = "txt_ProjeAdi";
            this.txt_ProjeAdi.Size = new System.Drawing.Size(535, 22);
            this.txt_ProjeAdi.TabIndex = 8;
            // 
            // btn_Bitir
            // 
            this.btn_Bitir.Location = new System.Drawing.Point(556, 327);
            this.btn_Bitir.Name = "btn_Bitir";
            this.btn_Bitir.Size = new System.Drawing.Size(98, 55);
            this.btn_Bitir.TabIndex = 16;
            this.btn_Bitir.Text = "Bitir";
            this.btn_Bitir.UseVisualStyleBackColor = true;
            this.btn_Bitir.Click += new System.EventHandler(this.btn_Bitir_Click);
            // 
            // BitisOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 391);
            this.Controls.Add(this.btn_Bitir);
            this.Controls.Add(this.groupBox1);
            this.Name = "BitisOnay";
            this.Text = "BitisOnay";
            this.Load += new System.EventHandler(this.BitisOnay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_Aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ProjeAdi;
        private System.Windows.Forms.Button btn_Bitir;
    }
}