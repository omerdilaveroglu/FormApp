
namespace WindowsFormsUI
{
    partial class GirisFormu
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
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.tbxKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(63, 57);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(92, 18);
            this.lblKullanıcıAdı.TabIndex = 0;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(63, 118);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(44, 18);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre :";
            // 
            // tbxKullanıcıAdı
            // 
            this.tbxKullanıcıAdı.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxKullanıcıAdı.Location = new System.Drawing.Point(177, 55);
            this.tbxKullanıcıAdı.Name = "tbxKullanıcıAdı";
            this.tbxKullanıcıAdı.Size = new System.Drawing.Size(184, 22);
            this.tbxKullanıcıAdı.TabIndex = 2;
            // 
            // tbxSifre
            // 
            this.tbxSifre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxSifre.Location = new System.Drawing.Point(177, 118);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.PasswordChar = '*';
            this.tbxSifre.Size = new System.Drawing.Size(184, 22);
            this.tbxSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGirisYap.Location = new System.Drawing.Point(177, 188);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(184, 32);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 293);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.tbxKullanıcıAdı);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Name = "GirisFormu";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox tbxKullanıcıAdı;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.Button btnGirisYap;
    }
}

