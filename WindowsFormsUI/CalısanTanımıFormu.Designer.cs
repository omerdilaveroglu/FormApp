
namespace WindowsFormsUI
{
    partial class CalısanTanımıFormu
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
            this.dgwCalısanTanımı = new System.Windows.Forms.DataGridView();
            this.lblAdEkle = new System.Windows.Forms.Label();
            this.gbxEkleme = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxAylıkMaliyetEkle = new System.Windows.Forms.TextBox();
            this.tbxBirimMaliyetEkle = new System.Windows.Forms.TextBox();
            this.tbxGoreviEkle = new System.Windows.Forms.TextBox();
            this.tbxTcEkle = new System.Windows.Forms.TextBox();
            this.tbxSoyadıEkle = new System.Windows.Forms.TextBox();
            this.tbxAdıEkle = new System.Windows.Forms.TextBox();
            this.lblAylıkMaliyetiEkle = new System.Windows.Forms.Label();
            this.lblSaatMaliyetEkle = new System.Windows.Forms.Label();
            this.lblGörevEkle = new System.Windows.Forms.Label();
            this.lblTcEkle = new System.Windows.Forms.Label();
            this.lblSoyadıEkle = new System.Windows.Forms.Label();
            this.tbxArama = new System.Windows.Forms.TextBox();
            this.lblAdArama = new System.Windows.Forms.Label();
            this.gbxGuncelleme = new System.Windows.Forms.GroupBox();
            this.btnGücelle = new System.Windows.Forms.Button();
            this.tbxAylıkMaliyetGüncelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBirimMaliyetGüncelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxGoreviGüncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTcGüncelle = new System.Windows.Forms.TextBox();
            this.tbxSoyadıGüncelle = new System.Windows.Forms.TextBox();
            this.tbxAdıGüncelle = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalısanTanımı)).BeginInit();
            this.gbxEkleme.SuspendLayout();
            this.gbxGuncelleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCalısanTanımı
            // 
            this.dgwCalısanTanımı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCalısanTanımı.Location = new System.Drawing.Point(12, 61);
            this.dgwCalısanTanımı.Name = "dgwCalısanTanımı";
            this.dgwCalısanTanımı.RowHeadersWidth = 51;
            this.dgwCalısanTanımı.RowTemplate.Height = 24;
            this.dgwCalısanTanımı.Size = new System.Drawing.Size(1028, 202);
            this.dgwCalısanTanımı.TabIndex = 0;
            this.dgwCalısanTanımı.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCalısanTanımı_CellClick);
            // 
            // lblAdEkle
            // 
            this.lblAdEkle.AutoSize = true;
            this.lblAdEkle.Location = new System.Drawing.Point(47, 26);
            this.lblAdEkle.Name = "lblAdEkle";
            this.lblAdEkle.Size = new System.Drawing.Size(36, 17);
            this.lblAdEkle.TabIndex = 1;
            this.lblAdEkle.Text = "Adı :";
            // 
            // gbxEkleme
            // 
            this.gbxEkleme.Controls.Add(this.btnEkle);
            this.gbxEkleme.Controls.Add(this.tbxAylıkMaliyetEkle);
            this.gbxEkleme.Controls.Add(this.tbxBirimMaliyetEkle);
            this.gbxEkleme.Controls.Add(this.tbxGoreviEkle);
            this.gbxEkleme.Controls.Add(this.tbxTcEkle);
            this.gbxEkleme.Controls.Add(this.tbxSoyadıEkle);
            this.gbxEkleme.Controls.Add(this.tbxAdıEkle);
            this.gbxEkleme.Controls.Add(this.lblAylıkMaliyetiEkle);
            this.gbxEkleme.Controls.Add(this.lblSaatMaliyetEkle);
            this.gbxEkleme.Controls.Add(this.lblGörevEkle);
            this.gbxEkleme.Controls.Add(this.lblTcEkle);
            this.gbxEkleme.Controls.Add(this.lblSoyadıEkle);
            this.gbxEkleme.Controls.Add(this.lblAdEkle);
            this.gbxEkleme.Location = new System.Drawing.Point(12, 319);
            this.gbxEkleme.Name = "gbxEkleme";
            this.gbxEkleme.Size = new System.Drawing.Size(522, 352);
            this.gbxEkleme.TabIndex = 2;
            this.gbxEkleme.TabStop = false;
            this.gbxEkleme.Text = "Ekleme";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEkle.Location = new System.Drawing.Point(274, 301);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(203, 36);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxAylıkMaliyetEkle
            // 
            this.tbxAylıkMaliyetEkle.Location = new System.Drawing.Point(222, 252);
            this.tbxAylıkMaliyetEkle.Name = "tbxAylıkMaliyetEkle";
            this.tbxAylıkMaliyetEkle.Size = new System.Drawing.Size(255, 22);
            this.tbxAylıkMaliyetEkle.TabIndex = 12;
            // 
            // tbxBirimMaliyetEkle
            // 
            this.tbxBirimMaliyetEkle.Location = new System.Drawing.Point(222, 205);
            this.tbxBirimMaliyetEkle.Name = "tbxBirimMaliyetEkle";
            this.tbxBirimMaliyetEkle.Size = new System.Drawing.Size(255, 22);
            this.tbxBirimMaliyetEkle.TabIndex = 11;
            // 
            // tbxGoreviEkle
            // 
            this.tbxGoreviEkle.Location = new System.Drawing.Point(222, 157);
            this.tbxGoreviEkle.Name = "tbxGoreviEkle";
            this.tbxGoreviEkle.Size = new System.Drawing.Size(255, 22);
            this.tbxGoreviEkle.TabIndex = 10;
            // 
            // tbxTcEkle
            // 
            this.tbxTcEkle.Location = new System.Drawing.Point(222, 114);
            this.tbxTcEkle.Name = "tbxTcEkle";
            this.tbxTcEkle.Size = new System.Drawing.Size(255, 22);
            this.tbxTcEkle.TabIndex = 9;
            // 
            // tbxSoyadıEkle
            // 
            this.tbxSoyadıEkle.Location = new System.Drawing.Point(222, 70);
            this.tbxSoyadıEkle.Name = "tbxSoyadıEkle";
            this.tbxSoyadıEkle.Size = new System.Drawing.Size(255, 22);
            this.tbxSoyadıEkle.TabIndex = 8;
            // 
            // tbxAdıEkle
            // 
            this.tbxAdıEkle.Location = new System.Drawing.Point(222, 26);
            this.tbxAdıEkle.Name = "tbxAdıEkle";
            this.tbxAdıEkle.Size = new System.Drawing.Size(255, 22);
            this.tbxAdıEkle.TabIndex = 7;
            // 
            // lblAylıkMaliyetiEkle
            // 
            this.lblAylıkMaliyetiEkle.AutoSize = true;
            this.lblAylıkMaliyetiEkle.Location = new System.Drawing.Point(48, 255);
            this.lblAylıkMaliyetiEkle.Name = "lblAylıkMaliyetiEkle";
            this.lblAylıkMaliyetiEkle.Size = new System.Drawing.Size(96, 17);
            this.lblAylıkMaliyetiEkle.TabIndex = 6;
            this.lblAylıkMaliyetiEkle.Text = "Aylık Maliyeti :";
            // 
            // lblSaatMaliyetEkle
            // 
            this.lblSaatMaliyetEkle.AutoSize = true;
            this.lblSaatMaliyetEkle.Location = new System.Drawing.Point(47, 205);
            this.lblSaatMaliyetEkle.Name = "lblSaatMaliyetEkle";
            this.lblSaatMaliyetEkle.Size = new System.Drawing.Size(131, 17);
            this.lblSaatMaliyetEkle.TabIndex = 5;
            this.lblSaatMaliyetEkle.Text = "Birim Saat Maliyeti :";
            // 
            // lblGörevEkle
            // 
            this.lblGörevEkle.AutoSize = true;
            this.lblGörevEkle.Location = new System.Drawing.Point(47, 157);
            this.lblGörevEkle.Name = "lblGörevEkle";
            this.lblGörevEkle.Size = new System.Drawing.Size(58, 17);
            this.lblGörevEkle.TabIndex = 4;
            this.lblGörevEkle.Text = "Görevi :";
            // 
            // lblTcEkle
            // 
            this.lblTcEkle.AutoSize = true;
            this.lblTcEkle.Location = new System.Drawing.Point(47, 114);
            this.lblTcEkle.Name = "lblTcEkle";
            this.lblTcEkle.Size = new System.Drawing.Size(94, 17);
            this.lblTcEkle.TabIndex = 3;
            this.lblTcEkle.Text = "Tc Kimlik No :";
            // 
            // lblSoyadıEkle
            // 
            this.lblSoyadıEkle.AutoSize = true;
            this.lblSoyadıEkle.Location = new System.Drawing.Point(47, 70);
            this.lblSoyadıEkle.Name = "lblSoyadıEkle";
            this.lblSoyadıEkle.Size = new System.Drawing.Size(59, 17);
            this.lblSoyadıEkle.TabIndex = 2;
            this.lblSoyadıEkle.Text = "Soyadı :";
            // 
            // tbxArama
            // 
            this.tbxArama.Location = new System.Drawing.Point(101, 23);
            this.tbxArama.Name = "tbxArama";
            this.tbxArama.Size = new System.Drawing.Size(214, 22);
            this.tbxArama.TabIndex = 3;
            this.tbxArama.TextChanged += new System.EventHandler(this.tbxArama_TextChanged);
            // 
            // lblAdArama
            // 
            this.lblAdArama.AutoSize = true;
            this.lblAdArama.Location = new System.Drawing.Point(12, 23);
            this.lblAdArama.Name = "lblAdArama";
            this.lblAdArama.Size = new System.Drawing.Size(61, 17);
            this.lblAdArama.TabIndex = 4;
            this.lblAdArama.Text = "Arama : ";
            // 
            // gbxGuncelleme
            // 
            this.gbxGuncelleme.Controls.Add(this.btnGücelle);
            this.gbxGuncelleme.Controls.Add(this.tbxAylıkMaliyetGüncelle);
            this.gbxGuncelleme.Controls.Add(this.label1);
            this.gbxGuncelleme.Controls.Add(this.label2);
            this.gbxGuncelleme.Controls.Add(this.tbxBirimMaliyetGüncelle);
            this.gbxGuncelleme.Controls.Add(this.label3);
            this.gbxGuncelleme.Controls.Add(this.label4);
            this.gbxGuncelleme.Controls.Add(this.tbxGoreviGüncelle);
            this.gbxGuncelleme.Controls.Add(this.label5);
            this.gbxGuncelleme.Controls.Add(this.label6);
            this.gbxGuncelleme.Controls.Add(this.tbxTcGüncelle);
            this.gbxGuncelleme.Controls.Add(this.tbxSoyadıGüncelle);
            this.gbxGuncelleme.Controls.Add(this.tbxAdıGüncelle);
            this.gbxGuncelleme.Location = new System.Drawing.Point(557, 319);
            this.gbxGuncelleme.Name = "gbxGuncelleme";
            this.gbxGuncelleme.Size = new System.Drawing.Size(483, 352);
            this.gbxGuncelleme.TabIndex = 5;
            this.gbxGuncelleme.TabStop = false;
            this.gbxGuncelleme.Text = "Güncelle";
            // 
            // btnGücelle
            // 
            this.btnGücelle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGücelle.Location = new System.Drawing.Point(257, 301);
            this.btnGücelle.Name = "btnGücelle";
            this.btnGücelle.Size = new System.Drawing.Size(203, 36);
            this.btnGücelle.TabIndex = 14;
            this.btnGücelle.Text = "Güncelle";
            this.btnGücelle.UseVisualStyleBackColor = false;
            this.btnGücelle.Click += new System.EventHandler(this.btnGücelle_Click);
            // 
            // tbxAylıkMaliyetGüncelle
            // 
            this.tbxAylıkMaliyetGüncelle.Location = new System.Drawing.Point(205, 252);
            this.tbxAylıkMaliyetGüncelle.Name = "tbxAylıkMaliyetGüncelle";
            this.tbxAylıkMaliyetGüncelle.Size = new System.Drawing.Size(255, 22);
            this.tbxAylıkMaliyetGüncelle.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aylık Maliyeti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Birim Saat Maliyeti :";
            // 
            // tbxBirimMaliyetGüncelle
            // 
            this.tbxBirimMaliyetGüncelle.Location = new System.Drawing.Point(205, 205);
            this.tbxBirimMaliyetGüncelle.Name = "tbxBirimMaliyetGüncelle";
            this.tbxBirimMaliyetGüncelle.Size = new System.Drawing.Size(255, 22);
            this.tbxBirimMaliyetGüncelle.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Görevi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tc Kimlik No :";
            // 
            // tbxGoreviGüncelle
            // 
            this.tbxGoreviGüncelle.Location = new System.Drawing.Point(205, 157);
            this.tbxGoreviGüncelle.Name = "tbxGoreviGüncelle";
            this.tbxGoreviGüncelle.Size = new System.Drawing.Size(255, 22);
            this.tbxGoreviGüncelle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Soyadı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adı :";
            // 
            // tbxTcGüncelle
            // 
            this.tbxTcGüncelle.Location = new System.Drawing.Point(205, 114);
            this.tbxTcGüncelle.Name = "tbxTcGüncelle";
            this.tbxTcGüncelle.Size = new System.Drawing.Size(255, 22);
            this.tbxTcGüncelle.TabIndex = 9;
            // 
            // tbxSoyadıGüncelle
            // 
            this.tbxSoyadıGüncelle.Location = new System.Drawing.Point(205, 70);
            this.tbxSoyadıGüncelle.Name = "tbxSoyadıGüncelle";
            this.tbxSoyadıGüncelle.Size = new System.Drawing.Size(255, 22);
            this.tbxSoyadıGüncelle.TabIndex = 8;
            // 
            // tbxAdıGüncelle
            // 
            this.tbxAdıGüncelle.Location = new System.Drawing.Point(205, 26);
            this.tbxAdıGüncelle.Name = "tbxAdıGüncelle";
            this.tbxAdıGüncelle.Size = new System.Drawing.Size(255, 22);
            this.tbxAdıGüncelle.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSil.Location = new System.Drawing.Point(754, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(255, 36);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeri.Location = new System.Drawing.Point(431, 683);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(227, 39);
            this.btnGeri.TabIndex = 16;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // CalısanTanımıFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 734);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gbxGuncelleme);
            this.Controls.Add(this.lblAdArama);
            this.Controls.Add(this.tbxArama);
            this.Controls.Add(this.gbxEkleme);
            this.Controls.Add(this.dgwCalısanTanımı);
            this.Name = "CalısanTanımıFormu";
            this.Text = "Calısan Tanımı Formu";
            this.Load += new System.EventHandler(this.CalısanTanımıFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalısanTanımı)).EndInit();
            this.gbxEkleme.ResumeLayout(false);
            this.gbxEkleme.PerformLayout();
            this.gbxGuncelleme.ResumeLayout(false);
            this.gbxGuncelleme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCalısanTanımı;
        private System.Windows.Forms.Label lblAdEkle;
        private System.Windows.Forms.GroupBox gbxEkleme;
        private System.Windows.Forms.Label lblGörevEkle;
        private System.Windows.Forms.Label lblTcEkle;
        private System.Windows.Forms.Label lblSoyadıEkle;
        private System.Windows.Forms.TextBox tbxBirimMaliyetEkle;
        private System.Windows.Forms.TextBox tbxGoreviEkle;
        private System.Windows.Forms.TextBox tbxTcEkle;
        private System.Windows.Forms.TextBox tbxSoyadıEkle;
        private System.Windows.Forms.TextBox tbxAdıEkle;
        private System.Windows.Forms.Label lblAylıkMaliyetiEkle;
        private System.Windows.Forms.Label lblSaatMaliyetEkle;
        private System.Windows.Forms.TextBox tbxArama;
        private System.Windows.Forms.Label lblAdArama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbxAylıkMaliyetEkle;
        private System.Windows.Forms.GroupBox gbxGuncelleme;
        private System.Windows.Forms.Button btnGücelle;
        private System.Windows.Forms.TextBox tbxAylıkMaliyetGüncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBirimMaliyetGüncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxGoreviGüncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTcGüncelle;
        private System.Windows.Forms.TextBox tbxSoyadıGüncelle;
        private System.Windows.Forms.TextBox tbxAdıGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
    }
}