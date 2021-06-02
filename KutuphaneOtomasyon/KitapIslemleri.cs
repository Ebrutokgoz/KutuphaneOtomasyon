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
    public partial class KitapIslemleri : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();
        public KitapIslemleri()
        {
            InitializeComponent();
        }

        private void KitapIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Show();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Show();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Hide();
        }

        private void eKitapListeleBtn_Click(object sender, EventArgs e)
        {
            
            eklePnl.Hide();
        }

        private void kKitapListeleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Hide();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
