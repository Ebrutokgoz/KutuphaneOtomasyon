
namespace KutuphaneOtomasyon
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.CalisanEpostaTxt = new System.Windows.Forms.TextBox();
            this.PersonelAdLbl = new System.Windows.Forms.Label();
            this.SifreLbl = new System.Windows.Forms.Label();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalisanEpostaTxt
            // 
            resources.ApplyResources(this.CalisanEpostaTxt, "CalisanEpostaTxt");
            this.CalisanEpostaTxt.Name = "CalisanEpostaTxt";
            this.CalisanEpostaTxt.TextChanged += new System.EventHandler(this.PersonelAdTxt_TextChanged);
            // 
            // PersonelAdLbl
            // 
            resources.ApplyResources(this.PersonelAdLbl, "PersonelAdLbl");
            this.PersonelAdLbl.BackColor = System.Drawing.Color.Transparent;
            this.PersonelAdLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PersonelAdLbl.Name = "PersonelAdLbl";
            // 
            // SifreLbl
            // 
            resources.ApplyResources(this.SifreLbl, "SifreLbl");
            this.SifreLbl.BackColor = System.Drawing.Color.Transparent;
            this.SifreLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SifreLbl.Name = "SifreLbl";
            // 
            // SifreTxt
            // 
            resources.ApplyResources(this.SifreTxt, "SifreTxt");
            this.SifreTxt.Name = "SifreTxt";
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.GirisBtn, "GirisBtn");
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PersonelAdLbl);
            this.panel1.Controls.Add(this.GirisBtn);
            this.panel1.Controls.Add(this.CalisanEpostaTxt);
            this.panel1.Controls.Add(this.SifreTxt);
            this.panel1.Controls.Add(this.SifreLbl);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // GirisEkrani
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GirisEkrani";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CalisanEpostaTxt;
        private System.Windows.Forms.Label PersonelAdLbl;
        private System.Windows.Forms.Label SifreLbl;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

