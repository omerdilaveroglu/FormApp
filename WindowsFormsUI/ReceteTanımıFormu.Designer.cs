
namespace WindowsFormsUI
{
    partial class ReceteTanımıFormu
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
            this.dgwReceteTanımı = new System.Windows.Forms.DataGridView();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.tbxMiktarSayısıEkle = new System.Windows.Forms.TextBox();
            this.lblMiktarEkle = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxSatırsayısıEkle = new System.Windows.Forms.TextBox();
            this.lblSatırSayısıEkle = new System.Windows.Forms.Label();
            this.tbxAcıklamaEkle = new System.Windows.Forms.TextBox();
            this.lblAcıklamaEkle = new System.Windows.Forms.Label();
            this.tbxAnaUrunKoduEkle = new System.Windows.Forms.TextBox();
            this.lblAnaUrunKoduEkle = new System.Windows.Forms.Label();
            this.gbxGuncelle = new System.Windows.Forms.GroupBox();
            this.tbxMiktarSayısıGuncelle = new System.Windows.Forms.TextBox();
            this.lblMiktarSayısıGuncelle = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbxSatırsayısıGuncelle = new System.Windows.Forms.TextBox();
            this.lblSatırSayısıGuncelle = new System.Windows.Forms.Label();
            this.tbxAcıklamaGuncelle = new System.Windows.Forms.TextBox();
            this.lblAcıklamaGuncelle = new System.Windows.Forms.Label();
            this.tbxAnaUrunKoduGuncelle = new System.Windows.Forms.TextBox();
            this.lblAnaUrunKoduGuncelle = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReceteTanımı)).BeginInit();
            this.gbxEkle.SuspendLayout();
            this.gbxGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwReceteTanımı
            // 
            this.dgwReceteTanımı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReceteTanımı.Location = new System.Drawing.Point(12, 29);
            this.dgwReceteTanımı.Name = "dgwReceteTanımı";
            this.dgwReceteTanımı.RowHeadersWidth = 51;
            this.dgwReceteTanımı.RowTemplate.Height = 24;
            this.dgwReceteTanımı.Size = new System.Drawing.Size(1003, 179);
            this.dgwReceteTanımı.TabIndex = 0;
            this.dgwReceteTanımı.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwReceteTanımı_CellClick);
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.tbxMiktarSayısıEkle);
            this.gbxEkle.Controls.Add(this.lblMiktarEkle);
            this.gbxEkle.Controls.Add(this.btnEkle);
            this.gbxEkle.Controls.Add(this.tbxSatırsayısıEkle);
            this.gbxEkle.Controls.Add(this.lblSatırSayısıEkle);
            this.gbxEkle.Controls.Add(this.tbxAcıklamaEkle);
            this.gbxEkle.Controls.Add(this.lblAcıklamaEkle);
            this.gbxEkle.Controls.Add(this.tbxAnaUrunKoduEkle);
            this.gbxEkle.Controls.Add(this.lblAnaUrunKoduEkle);
            this.gbxEkle.Location = new System.Drawing.Point(13, 265);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Size = new System.Drawing.Size(470, 275);
            this.gbxEkle.TabIndex = 1;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Ekle";
            // 
            // tbxMiktarSayısıEkle
            // 
            this.tbxMiktarSayısıEkle.Location = new System.Drawing.Point(187, 140);
            this.tbxMiktarSayısıEkle.Name = "tbxMiktarSayısıEkle";
            this.tbxMiktarSayısıEkle.Size = new System.Drawing.Size(204, 22);
            this.tbxMiktarSayısıEkle.TabIndex = 8;
            // 
            // lblMiktarEkle
            // 
            this.lblMiktarEkle.AutoSize = true;
            this.lblMiktarEkle.Location = new System.Drawing.Point(30, 145);
            this.lblMiktarEkle.Name = "lblMiktarEkle";
            this.lblMiktarEkle.Size = new System.Drawing.Size(95, 17);
            this.lblMiktarEkle.TabIndex = 7;
            this.lblMiktarEkle.Text = "Miktar Sayısı :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEkle.Location = new System.Drawing.Point(219, 228);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(172, 41);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxSatırsayısıEkle
            // 
            this.tbxSatırsayısıEkle.Location = new System.Drawing.Point(187, 93);
            this.tbxSatırsayısıEkle.Name = "tbxSatırsayısıEkle";
            this.tbxSatırsayısıEkle.Size = new System.Drawing.Size(204, 22);
            this.tbxSatırsayısıEkle.TabIndex = 5;
            // 
            // lblSatırSayısıEkle
            // 
            this.lblSatırSayısıEkle.AutoSize = true;
            this.lblSatırSayısıEkle.Location = new System.Drawing.Point(30, 98);
            this.lblSatırSayısıEkle.Name = "lblSatırSayısıEkle";
            this.lblSatırSayısıEkle.Size = new System.Drawing.Size(86, 17);
            this.lblSatırSayısıEkle.TabIndex = 4;
            this.lblSatırSayısıEkle.Text = "Satır Sayısı :";
            // 
            // tbxAcıklamaEkle
            // 
            this.tbxAcıklamaEkle.Location = new System.Drawing.Point(187, 190);
            this.tbxAcıklamaEkle.Name = "tbxAcıklamaEkle";
            this.tbxAcıklamaEkle.Size = new System.Drawing.Size(204, 22);
            this.tbxAcıklamaEkle.TabIndex = 3;
            // 
            // lblAcıklamaEkle
            // 
            this.lblAcıklamaEkle.AutoSize = true;
            this.lblAcıklamaEkle.Location = new System.Drawing.Point(30, 195);
            this.lblAcıklamaEkle.Name = "lblAcıklamaEkle";
            this.lblAcıklamaEkle.Size = new System.Drawing.Size(72, 17);
            this.lblAcıklamaEkle.TabIndex = 2;
            this.lblAcıklamaEkle.Text = "Açıklama :";
            // 
            // tbxAnaUrunKoduEkle
            // 
            this.tbxAnaUrunKoduEkle.Location = new System.Drawing.Point(187, 47);
            this.tbxAnaUrunKoduEkle.Name = "tbxAnaUrunKoduEkle";
            this.tbxAnaUrunKoduEkle.Size = new System.Drawing.Size(204, 22);
            this.tbxAnaUrunKoduEkle.TabIndex = 1;
            // 
            // lblAnaUrunKoduEkle
            // 
            this.lblAnaUrunKoduEkle.AutoSize = true;
            this.lblAnaUrunKoduEkle.Location = new System.Drawing.Point(30, 52);
            this.lblAnaUrunKoduEkle.Name = "lblAnaUrunKoduEkle";
            this.lblAnaUrunKoduEkle.Size = new System.Drawing.Size(109, 17);
            this.lblAnaUrunKoduEkle.TabIndex = 0;
            this.lblAnaUrunKoduEkle.Text = "Ana ürün kodu :";
            // 
            // gbxGuncelle
            // 
            this.gbxGuncelle.Controls.Add(this.tbxMiktarSayısıGuncelle);
            this.gbxGuncelle.Controls.Add(this.lblMiktarSayısıGuncelle);
            this.gbxGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxGuncelle.Controls.Add(this.tbxSatırsayısıGuncelle);
            this.gbxGuncelle.Controls.Add(this.lblSatırSayısıGuncelle);
            this.gbxGuncelle.Controls.Add(this.tbxAcıklamaGuncelle);
            this.gbxGuncelle.Controls.Add(this.lblAcıklamaGuncelle);
            this.gbxGuncelle.Controls.Add(this.tbxAnaUrunKoduGuncelle);
            this.gbxGuncelle.Controls.Add(this.lblAnaUrunKoduGuncelle);
            this.gbxGuncelle.Location = new System.Drawing.Point(545, 265);
            this.gbxGuncelle.Name = "gbxGuncelle";
            this.gbxGuncelle.Size = new System.Drawing.Size(470, 275);
            this.gbxGuncelle.TabIndex = 2;
            this.gbxGuncelle.TabStop = false;
            this.gbxGuncelle.Text = "Güncelle";
            // 
            // tbxMiktarSayısıGuncelle
            // 
            this.tbxMiktarSayısıGuncelle.Location = new System.Drawing.Point(187, 140);
            this.tbxMiktarSayısıGuncelle.Name = "tbxMiktarSayısıGuncelle";
            this.tbxMiktarSayısıGuncelle.Size = new System.Drawing.Size(204, 22);
            this.tbxMiktarSayısıGuncelle.TabIndex = 8;
            // 
            // lblMiktarSayısıGuncelle
            // 
            this.lblMiktarSayısıGuncelle.AutoSize = true;
            this.lblMiktarSayısıGuncelle.Location = new System.Drawing.Point(30, 145);
            this.lblMiktarSayısıGuncelle.Name = "lblMiktarSayısıGuncelle";
            this.lblMiktarSayısıGuncelle.Size = new System.Drawing.Size(95, 17);
            this.lblMiktarSayısıGuncelle.TabIndex = 7;
            this.lblMiktarSayısıGuncelle.Text = "Miktar Sayısı :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuncelle.Location = new System.Drawing.Point(219, 228);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(172, 41);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbxSatırsayısıGuncelle
            // 
            this.tbxSatırsayısıGuncelle.Location = new System.Drawing.Point(187, 93);
            this.tbxSatırsayısıGuncelle.Name = "tbxSatırsayısıGuncelle";
            this.tbxSatırsayısıGuncelle.Size = new System.Drawing.Size(204, 22);
            this.tbxSatırsayısıGuncelle.TabIndex = 5;
            // 
            // lblSatırSayısıGuncelle
            // 
            this.lblSatırSayısıGuncelle.AutoSize = true;
            this.lblSatırSayısıGuncelle.Location = new System.Drawing.Point(30, 98);
            this.lblSatırSayısıGuncelle.Name = "lblSatırSayısıGuncelle";
            this.lblSatırSayısıGuncelle.Size = new System.Drawing.Size(86, 17);
            this.lblSatırSayısıGuncelle.TabIndex = 4;
            this.lblSatırSayısıGuncelle.Text = "Satır Sayısı :";
            // 
            // tbxAcıklamaGuncelle
            // 
            this.tbxAcıklamaGuncelle.Location = new System.Drawing.Point(187, 190);
            this.tbxAcıklamaGuncelle.Name = "tbxAcıklamaGuncelle";
            this.tbxAcıklamaGuncelle.Size = new System.Drawing.Size(204, 22);
            this.tbxAcıklamaGuncelle.TabIndex = 3;
            // 
            // lblAcıklamaGuncelle
            // 
            this.lblAcıklamaGuncelle.AutoSize = true;
            this.lblAcıklamaGuncelle.Location = new System.Drawing.Point(30, 195);
            this.lblAcıklamaGuncelle.Name = "lblAcıklamaGuncelle";
            this.lblAcıklamaGuncelle.Size = new System.Drawing.Size(72, 17);
            this.lblAcıklamaGuncelle.TabIndex = 2;
            this.lblAcıklamaGuncelle.Text = "Açıklama :";
            // 
            // tbxAnaUrunKoduGuncelle
            // 
            this.tbxAnaUrunKoduGuncelle.Location = new System.Drawing.Point(187, 47);
            this.tbxAnaUrunKoduGuncelle.Name = "tbxAnaUrunKoduGuncelle";
            this.tbxAnaUrunKoduGuncelle.Size = new System.Drawing.Size(204, 22);
            this.tbxAnaUrunKoduGuncelle.TabIndex = 1;
            // 
            // lblAnaUrunKoduGuncelle
            // 
            this.lblAnaUrunKoduGuncelle.AutoSize = true;
            this.lblAnaUrunKoduGuncelle.Location = new System.Drawing.Point(30, 52);
            this.lblAnaUrunKoduGuncelle.Name = "lblAnaUrunKoduGuncelle";
            this.lblAnaUrunKoduGuncelle.Size = new System.Drawing.Size(109, 17);
            this.lblAnaUrunKoduGuncelle.TabIndex = 0;
            this.lblAnaUrunKoduGuncelle.Text = "Ana ürün kodu :";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSil.Location = new System.Drawing.Point(744, 224);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(236, 35);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeri.Location = new System.Drawing.Point(406, 556);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(227, 39);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ReceteTanımıFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 607);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gbxGuncelle);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.dgwReceteTanımı);
            this.Name = "ReceteTanımıFormu";
            this.Text = "Recete Tanımı ";
            this.Load += new System.EventHandler(this.ReceteTanımıFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwReceteTanımı)).EndInit();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            this.gbxGuncelle.ResumeLayout(false);
            this.gbxGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwReceteTanımı;
        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.TextBox tbxMiktarSayısıEkle;
        private System.Windows.Forms.Label lblMiktarEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbxSatırsayısıEkle;
        private System.Windows.Forms.Label lblSatırSayısıEkle;
        private System.Windows.Forms.TextBox tbxAcıklamaEkle;
        private System.Windows.Forms.Label lblAcıklamaEkle;
        private System.Windows.Forms.TextBox tbxAnaUrunKoduEkle;
        private System.Windows.Forms.Label lblAnaUrunKoduEkle;
        private System.Windows.Forms.GroupBox gbxGuncelle;
        private System.Windows.Forms.TextBox tbxMiktarSayısıGuncelle;
        private System.Windows.Forms.Label lblMiktarSayısıGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbxSatırsayısıGuncelle;
        private System.Windows.Forms.Label lblSatırSayısıGuncelle;
        private System.Windows.Forms.TextBox tbxAcıklamaGuncelle;
        private System.Windows.Forms.Label lblAcıklamaGuncelle;
        private System.Windows.Forms.TextBox tbxAnaUrunKoduGuncelle;
        private System.Windows.Forms.Label lblAnaUrunKoduGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
    }
}