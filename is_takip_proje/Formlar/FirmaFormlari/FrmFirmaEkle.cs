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

namespace is_takip_proje.Formlar
{
    public partial class FrmFirmaEkle : Form
    {
        public FrmFirmaEkle()
        {
            InitializeComponent();
        }
        DbisTakipEntities db=new DbisTakipEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblFirmalar f = new TblFirmalar();

           f.Ad=TxtAd.Text;
            f.Yetkili=TxtYetkili.Text;  
            f.Telefon=TxtTelefon.Text;  
            f.Mail=TxtMail.Text;
            f.Sektor = TxtSektor.Text;
            f.il = Txtİl.Text;
            db.TblFirmalar.Add(f);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Firma Başarı ile Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();



        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFirmaEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
