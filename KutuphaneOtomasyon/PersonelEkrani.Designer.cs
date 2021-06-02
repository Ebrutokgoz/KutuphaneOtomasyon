
namespace KutuphaneOtomasyon
{
    partial class PersonelEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkrani));
            this.kitapIslemleriBtn = new System.Windows.Forms.Button();
            this.UyeIslemleriBtn = new System.Windows.Forms.Button();
            this.emanetIslemleriBtn = new System.Windows.Forms.Button();
            this.kütüphaneLbl = new System.Windows.Forms.Label();
            this.adSoyadLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kitapIslemleriBtn
            // 
            resources.ApplyResources(this.kitapIslemleriBtn, "kitapIslemleriBtn");
            this.kitapIslemleriBtn.Name = "kitapIslemleriBtn";
            this.kitapIslemleriBtn.UseVisualStyleBackColor = true;
            this.kitapIslemleriBtn.Click += new System.EventHandler(this.kitapIslemleriBtn_Click);
            // 
            // UyeIslemleriBtn
            // 
            resources.ApplyResources(this.UyeIslemleriBtn, "UyeIslemleriBtn");
            this.UyeIslemleriBtn.Name = "UyeIslemleriBtn";
            this.UyeIslemleriBtn.UseVisualStyleBackColor = true;
            this.UyeIslemleriBtn.Click += new System.EventHandler(this.UyeIslemleriBtn_Click);
            // 
            // emanetIslemleriBtn
            // 
            resources.ApplyResources(this.emanetIslemleriBtn, "emanetIslemleriBtn");
            this.emanetIslemleriBtn.Name = "emanetIslemleriBtn";
            this.emanetIslemleriBtn.UseVisualStyleBackColor = true;
            this.emanetIslemleriBtn.Click += new System.EventHandler(this.emanetIslemleriBtn_Click);
            // 
            // kütüphaneLbl
            // 
            resources.ApplyResources(this.kütüphaneLbl, "kütüphaneLbl");
            this.kütüphaneLbl.Name = "kütüphaneLbl";
            // 
            // adSoyadLbl
            // 
            resources.ApplyResources(this.adSoyadLbl, "adSoyadLbl");
            this.adSoyadLbl.Name = "adSoyadLbl";
            // 
            // PersonelEkrani
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adSoyadLbl);
            this.Controls.Add(this.kütüphaneLbl);
            this.Controls.Add(this.emanetIslemleriBtn);
            this.Controls.Add(this.UyeIslemleriBtn);
            this.Controls.Add(this.kitapIslemleriBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonelEkrani";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kitapIslemleriBtn;
        private System.Windows.Forms.Button UyeIslemleriBtn;
        private System.Windows.Forms.Button emanetIslemleriBtn;
        private System.Windows.Forms.Label kütüphaneLbl;
        private System.Windows.Forms.Label adSoyadLbl;
    }
}