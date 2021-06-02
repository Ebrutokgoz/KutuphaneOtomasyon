
namespace KutuphaneOtomasyon
{
    partial class EmanetIslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanetVerBtn = new System.Windows.Forms.Button();
            this.teslimAlBtn = new System.Windows.Forms.Button();
            this.sorgulaBtn = new System.Windows.Forms.Button();
            this.kitapIdLbl = new System.Windows.Forms.Label();
            this.uyeIdLbl = new System.Windows.Forms.Label();
            this.kitapUyePnl = new System.Windows.Forms.Panel();
            this.uyeIdTxt = new System.Windows.Forms.TextBox();
            this.kitapPnl = new System.Windows.Forms.Panel();
            this.kitapIdTxt2 = new System.Windows.Forms.TextBox();
            this.kitapIdLbl2 = new System.Windows.Forms.Label();
            this.kitapIdTxt = new System.Windows.Forms.TextBox();
            this.kaydetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.kitapUyePnl.SuspendLayout();
            this.kitapPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(987, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // emanetVerBtn
            // 
            this.emanetVerBtn.Location = new System.Drawing.Point(70, 30);
            this.emanetVerBtn.Name = "emanetVerBtn";
            this.emanetVerBtn.Size = new System.Drawing.Size(176, 54);
            this.emanetVerBtn.TabIndex = 1;
            this.emanetVerBtn.Text = "Emanet kitap ver";
            this.emanetVerBtn.UseVisualStyleBackColor = true;
            this.emanetVerBtn.Click += new System.EventHandler(this.emanetVerBtn_Click);
            // 
            // teslimAlBtn
            // 
            this.teslimAlBtn.Location = new System.Drawing.Point(70, 90);
            this.teslimAlBtn.Name = "teslimAlBtn";
            this.teslimAlBtn.Size = new System.Drawing.Size(176, 54);
            this.teslimAlBtn.TabIndex = 2;
            this.teslimAlBtn.Text = "Emanet kitabı teslim al";
            this.teslimAlBtn.UseVisualStyleBackColor = true;
            this.teslimAlBtn.Click += new System.EventHandler(this.teslimAlBtn_Click);
            // 
            // sorgulaBtn
            // 
            this.sorgulaBtn.Location = new System.Drawing.Point(70, 150);
            this.sorgulaBtn.Name = "sorgulaBtn";
            this.sorgulaBtn.Size = new System.Drawing.Size(176, 54);
            this.sorgulaBtn.TabIndex = 3;
            this.sorgulaBtn.Text = "Emanet teslim günü sorgula";
            this.sorgulaBtn.UseVisualStyleBackColor = true;
            this.sorgulaBtn.Click += new System.EventHandler(this.sorgulaBtn_Click);
            // 
            // kitapIdLbl
            // 
            this.kitapIdLbl.AutoSize = true;
            this.kitapIdLbl.Location = new System.Drawing.Point(24, 44);
            this.kitapIdLbl.Name = "kitapIdLbl";
            this.kitapIdLbl.Size = new System.Drawing.Size(49, 13);
            this.kitapIdLbl.TabIndex = 0;
            this.kitapIdLbl.Text = "Kitap Id :";
            this.kitapIdLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kitapIdLbl.UseMnemonic = false;
            // 
            // uyeIdLbl
            // 
            this.uyeIdLbl.AllowDrop = true;
            this.uyeIdLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uyeIdLbl.AutoSize = true;
            this.uyeIdLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uyeIdLbl.Location = new System.Drawing.Point(24, 95);
            this.uyeIdLbl.Name = "uyeIdLbl";
            this.uyeIdLbl.Size = new System.Drawing.Size(44, 13);
            this.uyeIdLbl.TabIndex = 1;
            this.uyeIdLbl.Text = "Üye Id :";
            this.uyeIdLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uyeIdLbl.UseMnemonic = false;
            // 
            // kitapUyePnl
            // 
            this.kitapUyePnl.Controls.Add(this.uyeIdTxt);
            this.kitapUyePnl.Controls.Add(this.kitapPnl);
            this.kitapUyePnl.Controls.Add(this.kitapIdTxt);
            this.kitapUyePnl.Controls.Add(this.uyeIdLbl);
            this.kitapUyePnl.Controls.Add(this.kitapIdLbl);
            this.kitapUyePnl.Location = new System.Drawing.Point(451, 30);
            this.kitapUyePnl.Name = "kitapUyePnl";
            this.kitapUyePnl.Size = new System.Drawing.Size(376, 152);
            this.kitapUyePnl.TabIndex = 5;
            this.kitapUyePnl.Visible = false;
            // 
            // uyeIdTxt
            // 
            this.uyeIdTxt.Location = new System.Drawing.Point(100, 92);
            this.uyeIdTxt.Multiline = true;
            this.uyeIdTxt.Name = "uyeIdTxt";
            this.uyeIdTxt.Size = new System.Drawing.Size(241, 20);
            this.uyeIdTxt.TabIndex = 3;
            // 
            // kitapPnl
            // 
            this.kitapPnl.Controls.Add(this.kitapIdTxt2);
            this.kitapPnl.Controls.Add(this.kitapIdLbl2);
            this.kitapPnl.Location = new System.Drawing.Point(100, 0);
            this.kitapPnl.Name = "kitapPnl";
            this.kitapPnl.Size = new System.Drawing.Size(376, 152);
            this.kitapPnl.TabIndex = 6;
            this.kitapPnl.Visible = false;
            // 
            // kitapIdTxt2
            // 
            this.kitapIdTxt2.Location = new System.Drawing.Point(79, 37);
            this.kitapIdTxt2.Multiline = true;
            this.kitapIdTxt2.Name = "kitapIdTxt2";
            this.kitapIdTxt2.Size = new System.Drawing.Size(241, 20);
            this.kitapIdTxt2.TabIndex = 3;
            // 
            // kitapIdLbl2
            // 
            this.kitapIdLbl2.AutoSize = true;
            this.kitapIdLbl2.Location = new System.Drawing.Point(19, 41);
            this.kitapIdLbl2.Name = "kitapIdLbl2";
            this.kitapIdLbl2.Size = new System.Drawing.Size(49, 13);
            this.kitapIdLbl2.TabIndex = 0;
            this.kitapIdLbl2.Text = "Kitap Id :";
            this.kitapIdLbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kitapIdLbl2.UseMnemonic = false;
            // 
            // kitapIdTxt
            // 
            this.kitapIdTxt.Location = new System.Drawing.Point(100, 41);
            this.kitapIdTxt.Multiline = true;
            this.kitapIdTxt.Name = "kitapIdTxt";
            this.kitapIdTxt.Size = new System.Drawing.Size(241, 20);
            this.kitapIdTxt.TabIndex = 2;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(292, 87);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(92, 42);
            this.kaydetBtn.TabIndex = 7;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // EmanetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 616);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.kitapUyePnl);
            this.Controls.Add(this.sorgulaBtn);
            this.Controls.Add(this.teslimAlBtn);
            this.Controls.Add(this.emanetVerBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetIslemleri";
            this.Text = "EmanetIslemleri";
            this.Load += new System.EventHandler(this.EmanetIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.kitapUyePnl.ResumeLayout(false);
            this.kitapUyePnl.PerformLayout();
            this.kitapPnl.ResumeLayout(false);
            this.kitapPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button emanetVerBtn;
        private System.Windows.Forms.Button teslimAlBtn;
        private System.Windows.Forms.Button sorgulaBtn;
        private System.Windows.Forms.Label kitapIdLbl;
        private System.Windows.Forms.Label uyeIdLbl;
        private System.Windows.Forms.Panel kitapUyePnl;
        private System.Windows.Forms.TextBox uyeIdTxt;
        private System.Windows.Forms.TextBox kitapIdTxt;
        private System.Windows.Forms.Panel kitapPnl;
        private System.Windows.Forms.TextBox kitapIdTxt2;
        private System.Windows.Forms.Label kitapIdLbl2;
        private System.Windows.Forms.Button kaydetBtn;
    }
}