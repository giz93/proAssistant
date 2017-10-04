namespace Presentation
{
    partial class Developerlar
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_Aciklama = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ProjeAdi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_Gorev = new System.Windows.Forms.DataGridView();
            this.Gorevler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Developer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeveloperID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.cb_Developer = new System.Windows.Forms.ComboBox();
            this.txt_Gorevler = new System.Windows.Forms.TextBox();
            this.btn_Ata = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_dev = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Gorev)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dev)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DGV_dev, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.14815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.85185F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 675);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(303, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(676, 292);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rtxt_Aciklama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ProjeAdi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 292);
            this.groupBox1.TabIndex = 15;
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
            this.rtxt_Aciklama.Location = new System.Drawing.Point(119, 95);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.DGV_Gorev);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Ekle);
            this.panel1.Controls.Add(this.cb_Developer);
            this.panel1.Controls.Add(this.txt_Gorevler);
            this.panel1.Controls.Add(this.btn_Ata);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(303, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 371);
            this.panel1.TabIndex = 1;
            // 
            // DGV_Gorev
            // 
            this.DGV_Gorev.AllowUserToOrderColumns = true;
            this.DGV_Gorev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Gorev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gorevler,
            this.Developer,
            this.DeveloperID});
            this.DGV_Gorev.Location = new System.Drawing.Point(3, 100);
            this.DGV_Gorev.Name = "DGV_Gorev";
            this.DGV_Gorev.RowTemplate.Height = 24;
            this.DGV_Gorev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Gorev.Size = new System.Drawing.Size(638, 216);
            this.DGV_Gorev.TabIndex = 23;
            // 
            // Gorevler
            // 
            this.Gorevler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gorevler.HeaderText = "Gorevler";
            this.Gorevler.Name = "Gorevler";
            // 
            // Developer
            // 
            this.Developer.HeaderText = "Developer";
            this.Developer.Name = "Developer";
            // 
            // DeveloperID
            // 
            this.DeveloperID.HeaderText = "DeveloperID";
            this.DeveloperID.Name = "DeveloperID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Developer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Görevler";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(571, 34);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(86, 43);
            this.btn_Ekle.TabIndex = 19;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // cb_Developer
            // 
            this.cb_Developer.FormattingEnabled = true;
            this.cb_Developer.Location = new System.Drawing.Point(432, 34);
            this.cb_Developer.Name = "cb_Developer";
            this.cb_Developer.Size = new System.Drawing.Size(121, 24);
            this.cb_Developer.TabIndex = 18;
            // 
            // txt_Gorevler
            // 
            this.txt_Gorevler.Location = new System.Drawing.Point(19, 34);
            this.txt_Gorevler.Multiline = true;
            this.txt_Gorevler.Name = "txt_Gorevler";
            this.txt_Gorevler.Size = new System.Drawing.Size(407, 40);
            this.txt_Gorevler.TabIndex = 17;
            // 
            // btn_Ata
            // 
            this.btn_Ata.Location = new System.Drawing.Point(571, 322);
            this.btn_Ata.Name = "btn_Ata";
            this.btn_Ata.Size = new System.Drawing.Size(86, 40);
            this.btn_Ata.TabIndex = 16;
            this.btn_Ata.Text = "Ata";
            this.btn_Ata.UseVisualStyleBackColor = true;
            this.btn_Ata.Click += new System.EventHandler(this.btn_Ata_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 371);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(294, 371);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seçmek istediğiniz developerlara çift tıklayınız.";
            // 
            // DGV_dev
            // 
            this.DGV_dev.AllowUserToAddRows = false;
            this.DGV_dev.AllowUserToDeleteRows = false;
            this.DGV_dev.AllowUserToOrderColumns = true;
            this.DGV_dev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_dev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_dev.Location = new System.Drawing.Point(3, 3);
            this.DGV_dev.Name = "DGV_dev";
            this.DGV_dev.ReadOnly = true;
            this.DGV_dev.RowTemplate.Height = 24;
            this.DGV_dev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_dev.Size = new System.Drawing.Size(294, 292);
            this.DGV_dev.TabIndex = 4;
            this.DGV_dev.DoubleClick += new System.EventHandler(this.DGV_dev_DoubleClick);
            // 
            // Developerlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 675);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Developerlar";
            this.Text = "Developerlar";
            this.Load += new System.EventHandler(this.Developerlar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Gorev)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Ata;
        private System.Windows.Forms.DataGridView DGV_Gorev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ComboBox cb_Developer;
        private System.Windows.Forms.TextBox txt_Gorevler;
        private System.Windows.Forms.DataGridView DGV_dev;
        public System.Windows.Forms.RichTextBox rtxt_Aciklama;
        public System.Windows.Forms.TextBox txt_ProjeAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorevler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Developer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeveloperID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label5;
    }
}