using DevExpress.XtraEditors;
using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.PersonelGorevFormlari
{
    public partial class FrmCagriDetayGirisi : Form
    {
        public FrmCagriDetayGirisi()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        public int id;
        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCagriDetayGirisi_Load(object sender, EventArgs e)
        {
            TxtCagriID.Enabled = false;
            TxtCagriID.Text=id.ToString();  
            string saat, tarih;
            tarih = DateTime.Now.ToString();
            saat=DateTime.Now.ToShortTimeString();
            TxtTarih.Text = tarih;
            TxtSaatGiris.Text = saat;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetay t = new TblCagriDetay();
            t.Cagri = int.Parse(TxtCagriID.Text);
            t.Saat = TxtSaatGiris.Text;
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            t.Aciklama = TxtAciklama.Text;
            db.TblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayı Sisteme Başarılı Bir Şekilde Kaydedildi");

        }
    }
}
