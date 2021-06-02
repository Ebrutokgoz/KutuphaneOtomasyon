
namespace KutuphaneOtomasyon
{
    partial class YoneticiEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiEkrani));
            this.label4 = new System.Windows.Forms.Label();
            this.personelIslemleriBtn = new System.Windows.Forms.Button();
            this.personelSayfasiBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // personelIslemleriBtn
            // 
            resources.ApplyResources(this.personelIslemleriBtn, "personelIslemleriBtn");
            this.personelIslemleriBtn.Name = "personelIslemleriBtn";
            this.personelIslemleriBtn.UseVisualStyleBackColor = true;
            this.personelIslemleriBtn.Click += new System.EventHandler(this.personelIslemleriBtn_Click);
            // 
            // personelSayfasiBtn
            // 
            resources.ApplyResources(this.personelSayfasiBtn, "personelSayfasiBtn");
            this.personelSayfasiBtn.Name = "personelSayfasiBtn";
            this.personelSayfasiBtn.UseVisualStyleBackColor = true;
            this.personelSayfasiBtn.Click += new System.EventHandler(this.personelSayfasiBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // YoneticiEkrani
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelSayfasiBtn);
            this.Controls.Add(this.personelIslemleriBtn);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YoneticiEkrani";
            this.Load += new System.EventHandler(this.YoneticiEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button personelIslemleriBtn;
        private System.Windows.Forms.Button personelSayfasiBtn;
        private System.Windows.Forms.Label label1;
    }
}