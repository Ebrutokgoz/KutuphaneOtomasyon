using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class SignInWindow : Form
    {
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            string girilenAd = PersonelAdTxt.Text;
            string girilenSifre = SifreTxt.Text;

            if (girilenAd.Equals("Admin") &&  girilenSifre.Equals("123"))
            {
                MessageBox.Show(text: "Giriş başarılı");
            }
            else
            {
                MessageBox.Show(text: "Personel adı veya şifer hatalı");
            }

        }
    }
}
