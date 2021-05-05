
namespace WindowsFormsUI
{
    partial class AnaForm
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
            this.CalısanT = new System.Windows.Forms.Button();
            this.ReceteT = new System.Windows.Forms.Button();
            this.IsIstasyonT = new System.Windows.Forms.Button();
            this.OperasyonT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalısanT
            // 
            this.CalısanT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalısanT.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalısanT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalısanT.Location = new System.Drawing.Point(56, 67);
            this.CalısanT.Name = "CalısanT";
            this.CalısanT.Size = new System.Drawing.Size(282, 97);
            this.CalısanT.TabIndex = 0;
            this.CalısanT.Text = "ÇALIŞAN TANIMI";
            this.CalısanT.UseVisualStyleBackColor = false;
            this.CalısanT.Click += new System.EventHandler(this.CalısanT_Click);
            // 
            // ReceteT
            // 
            this.ReceteT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReceteT.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReceteT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReceteT.Location = new System.Drawing.Point(56, 265);
            this.ReceteT.Name = "ReceteT";
            this.ReceteT.Size = new System.Drawing.Size(282, 83);
            this.ReceteT.TabIndex = 1;
            this.ReceteT.Text = "REÇETE TANIMI";
            this.ReceteT.UseVisualStyleBackColor = false;
            this.ReceteT.Click += new System.EventHandler(this.ReceteT_Click);
            // 
            // IsIstasyonT
            // 
            this.IsIstasyonT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.IsIstasyonT.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsIstasyonT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsIstasyonT.Location = new System.Drawing.Point(435, 67);
            this.IsIstasyonT.Name = "IsIstasyonT";
            this.IsIstasyonT.Size = new System.Drawing.Size(290, 97);
            this.IsIstasyonT.TabIndex = 2;
            this.IsIstasyonT.Text = "İŞ İSTASYON TANIMI";
            this.IsIstasyonT.UseVisualStyleBackColor = false;
            this.IsIstasyonT.Click += new System.EventHandler(this.IsIstasyonT_Click);
            // 
            // OperasyonT
            // 
            this.OperasyonT.BackColor = System.Drawing.SystemColors.Info;
            this.OperasyonT.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OperasyonT.Location = new System.Drawing.Point(435, 265);
            this.OperasyonT.Name = "OperasyonT";
            this.OperasyonT.Size = new System.Drawing.Size(290, 83);
            this.OperasyonT.TabIndex = 3;
            this.OperasyonT.Text = "OPERASYON TANIMI";
            this.OperasyonT.UseVisualStyleBackColor = false;
            this.OperasyonT.Click += new System.EventHandler(this.OperasyonT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CalısanT);
            this.groupBox1.Controls.Add(this.OperasyonT);
            this.groupBox1.Controls.Add(this.ReceteT);
            this.groupBox1.Controls.Add(this.IsIstasyonT);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(74, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 416);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRETİM YÖNETİM SİSTEMİ";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(994, 577);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "Ana Sayfa";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalısanT;
        private System.Windows.Forms.Button ReceteT;
        private System.Windows.Forms.Button IsIstasyonT;
        private System.Windows.Forms.Button OperasyonT;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}