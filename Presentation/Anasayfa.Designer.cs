namespace Presentation
{
    partial class Anasayfa
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_Done = new System.Windows.Forms.ListBox();
            this.LB_Doing = new System.Windows.Forms.ListBox();
            this.LB_ToDo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_developer = new System.Windows.Forms.Label();
            this.LB_Gorevler = new System.Windows.Forms.ListBox();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_Profil = new System.Windows.Forms.Button();
            this.lbl_SonDurum = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.lbl_Kadi = new System.Windows.Forms.Label();
            this.lbl_Musteri = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 770);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Musteri);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(253, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 664);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_Done);
            this.groupBox1.Controls.Add(this.LB_Doing);
            this.groupBox1.Controls.Add(this.LB_ToDo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(68, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 511);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // LB_Done
            // 
            this.LB_Done.FormattingEnabled = true;
            this.LB_Done.ItemHeight = 16;
            this.LB_Done.Location = new System.Drawing.Point(487, 63);
            this.LB_Done.Name = "LB_Done";
            this.LB_Done.Size = new System.Drawing.Size(182, 420);
            this.LB_Done.TabIndex = 7;
            // 
            // LB_Doing
            // 
            this.LB_Doing.FormattingEnabled = true;
            this.LB_Doing.ItemHeight = 16;
            this.LB_Doing.Location = new System.Drawing.Point(253, 63);
            this.LB_Doing.Name = "LB_Doing";
            this.LB_Doing.Size = new System.Drawing.Size(182, 420);
            this.LB_Doing.TabIndex = 6;
            this.LB_Doing.DoubleClick += new System.EventHandler(this.LB_Doing_DoubleClick);
            // 
            // LB_ToDo
            // 
            this.LB_ToDo.FormattingEnabled = true;
            this.LB_ToDo.ItemHeight = 16;
            this.LB_ToDo.Location = new System.Drawing.Point(35, 63);
            this.LB_ToDo.Name = "LB_ToDo";
            this.LB_ToDo.Size = new System.Drawing.Size(182, 420);
            this.LB_ToDo.TabIndex = 4;
            this.LB_ToDo.DoubleClick += new System.EventHandler(this.LB_ToDo_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(552, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Done";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "To Do List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(318, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doing";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 94);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(37, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pro Assistant";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_developer);
            this.panel3.Controls.Add(this.LB_Gorevler);
            this.panel3.Controls.Add(this.btn_Cikis);
            this.panel3.Controls.Add(this.btn_Profil);
            this.panel3.Controls.Add(this.lbl_SonDurum);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 664);
            this.panel3.TabIndex = 2;
            // 
            // lbl_developer
            // 
            this.lbl_developer.AutoSize = true;
            this.lbl_developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_developer.ForeColor = System.Drawing.Color.Blue;
            this.lbl_developer.Location = new System.Drawing.Point(6, 324);
            this.lbl_developer.Name = "lbl_developer";
            this.lbl_developer.Size = new System.Drawing.Size(218, 18);
            this.lbl_developer.TabIndex = 10;
            this.lbl_developer.Text = "İncelemek için çift tıklayınız.";
            // 
            // LB_Gorevler
            // 
            this.LB_Gorevler.FormattingEnabled = true;
            this.LB_Gorevler.ItemHeight = 16;
            this.LB_Gorevler.Location = new System.Drawing.Point(4, 43);
            this.LB_Gorevler.Name = "LB_Gorevler";
            this.LB_Gorevler.Size = new System.Drawing.Size(237, 260);
            this.LB_Gorevler.TabIndex = 7;
            this.LB_Gorevler.DoubleClick += new System.EventHandler(this.LB_Gorevler_DoubleClick);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Location = new System.Drawing.Point(9, 607);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(214, 41);
            this.btn_Cikis.TabIndex = 5;
            this.btn_Cikis.Text = "Çıkış Yap";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_Profil
            // 
            this.btn_Profil.Location = new System.Drawing.Point(9, 560);
            this.btn_Profil.Name = "btn_Profil";
            this.btn_Profil.Size = new System.Drawing.Size(214, 41);
            this.btn_Profil.TabIndex = 4;
            this.btn_Profil.Text = "Profili Düzenle";
            this.btn_Profil.UseVisualStyleBackColor = true;
            this.btn_Profil.Click += new System.EventHandler(this.btn_Profil_Click);
            // 
            // lbl_SonDurum
            // 
            this.lbl_SonDurum.AutoSize = true;
            this.lbl_SonDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SonDurum.Location = new System.Drawing.Point(74, 14);
            this.lbl_SonDurum.Name = "lbl_SonDurum";
            this.lbl_SonDurum.Size = new System.Drawing.Size(71, 17);
            this.lbl_SonDurum.TabIndex = 1;
            this.lbl_SonDurum.Text = "Görevler";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_Tarih);
            this.panel4.Controls.Add(this.lbl_Kadi);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(253, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(842, 94);
            this.panel4.TabIndex = 3;
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(664, 68);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(41, 17);
            this.lbl_Tarih.TabIndex = 1;
            this.lbl_Tarih.Text = "Tarih";
            // 
            // lbl_Kadi
            // 
            this.lbl_Kadi.AutoSize = true;
            this.lbl_Kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kadi.Location = new System.Drawing.Point(19, 59);
            this.lbl_Kadi.Name = "lbl_Kadi";
            this.lbl_Kadi.Size = new System.Drawing.Size(148, 25);
            this.lbl_Kadi.TabIndex = 0;
            this.lbl_Kadi.Text = "Merhaba User";
            // 
            // lbl_Musteri
            // 
            this.lbl_Musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Musteri.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Musteri.Location = new System.Drawing.Point(100, 586);
            this.lbl_Musteri.Name = "lbl_Musteri";
            this.lbl_Musteri.Size = new System.Drawing.Size(637, 62);
            this.lbl_Musteri.TabIndex = 8;
            this.lbl_Musteri.Text = "Bugün yapmak istediğiniz projeye çift tıklayarak Doing listesine aktarabilirsiniz" +
    ". Doing listesinde kontrol ettiğiniz projeye çift tıklayarak gelen ekrandan iste" +
    "k ve buglarınızı gönderebilirsiniz. ";
            this.lbl_Musteri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 770);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Activated += new System.EventHandler(this.Anasayfa_Activated);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LB_ToDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_SonDurum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Label lbl_Kadi;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Button btn_Profil;
        private System.Windows.Forms.ListBox LB_Done;
        private System.Windows.Forms.ListBox LB_Gorevler;
        private System.Windows.Forms.Label lbl_developer;
        public System.Windows.Forms.ListBox LB_Doing;
        private System.Windows.Forms.Label lbl_Musteri;
    }
}