
namespace KutuphaneOtomasyon
{
    partial class SignInWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInWindow));
            this.PersonelAdTxt = new System.Windows.Forms.TextBox();
            this.PersonelAdLbl = new System.Windows.Forms.Label();
            this.SifreLbl = new System.Windows.Forms.Label();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonelAdTxt
            // 
            this.PersonelAdTxt.Location = new System.Drawing.Point(111, 52);
            this.PersonelAdTxt.Name = "PersonelAdTxt";
            this.PersonelAdTxt.Size = new System.Drawing.Size(171, 20);
            this.PersonelAdTxt.TabIndex = 0;
            // 
            // PersonelAdLbl
            // 
            this.PersonelAdLbl.AutoSize = true;
            this.PersonelAdLbl.BackColor = System.Drawing.Color.Transparent;
            this.PersonelAdLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PersonelAdLbl.Location = new System.Drawing.Point(21, 55);
            this.PersonelAdLbl.Name = "PersonelAdLbl";
            this.PersonelAdLbl.Size = new System.Drawing.Size(66, 13);
            this.PersonelAdLbl.TabIndex = 1;
            this.PersonelAdLbl.Text = "Personel Adı";
            // 
            // SifreLbl
            // 
            this.SifreLbl.AutoSize = true;
            this.SifreLbl.BackColor = System.Drawing.Color.Transparent;
            this.SifreLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SifreLbl.Location = new System.Drawing.Point(36, 112);
            this.SifreLbl.Name = "SifreLbl";
            this.SifreLbl.Size = new System.Drawing.Size(28, 13);
            this.SifreLbl.TabIndex = 2;
            this.SifreLbl.Text = "Şifre";
            // 
            // SifreTxt
            // 
            this.SifreTxt.Location = new System.Drawing.Point(111, 109);
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.Size = new System.Drawing.Size(171, 20);
            this.SifreTxt.TabIndex = 3;
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GirisBtn.Location = new System.Drawing.Point(69, 161);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(183, 37);
            this.GirisBtn.TabIndex = 4;
            this.GirisBtn.Text = "Giriş";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PersonelAdLbl);
            this.panel1.Controls.Add(this.GirisBtn);
            this.panel1.Controls.Add(this.PersonelAdTxt);
            this.panel1.Controls.Add(this.SifreTxt);
            this.panel1.Controls.Add(this.SifreLbl);
            this.panel1.Location = new System.Drawing.Point(56, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 228);
            this.panel1.TabIndex = 5;
            // 
            // SignInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 527);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignInWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PersonelAdTxt;
        private System.Windows.Forms.Label PersonelAdLbl;
        private System.Windows.Forms.Label SifreLbl;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

