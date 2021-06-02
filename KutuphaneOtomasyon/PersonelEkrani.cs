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
    public partial class PersonelEkrani : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();
        public PersonelEkrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kitapIslemleriBtn_Click(object sender, EventArgs e)
        {
            KitapIslemleri kitapIslemleri = new KitapIslemleri();
            kitapIslemleri.Show();
        }

        private void UyeIslemleriBtn_Click(object sender, EventArgs e)
        {
            UyeIslemleri uyeIslemleri = new UyeIslemleri();
            uyeIslemleri.Show();
        }

        private void emanetIslemleriBtn_Click(object sender, EventArgs e)
        {
            EmanetIslemleri emanetIslemleri = new EmanetIslemleri();
            emanetIslemleri.Show();
        }

       
    }
}
