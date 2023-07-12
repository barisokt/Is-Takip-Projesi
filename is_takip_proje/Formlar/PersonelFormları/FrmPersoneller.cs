using DevExpress.XtraEditors;
using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace is_takip_proje.Formlar
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();


        void personeller()
        {
            var degerler = from x in db.TblPersonel
                           select new
                           {

                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Mail,
                               departman =x.TblDepartmanlar.Ad,
                               x.Durum

                           };
            gridControl1.DataSource = degerler. Where(x=>x.Durum==true).ToList();



        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            personeller();

            var departmanlar = (from x in db.TblDepartmanlar
                                select new
                                {

                                    x.ID,
                                    x.Ad


                                }).ToList();

            lookUpEdit2.Properties.ValueMember=("ID");
            lookUpEdit2.Properties.DisplayMember = ("Ad");
            lookUpEdit2.Properties.DataSource = departmanlar;   

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            personeller();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                TblPersonel t = new TblPersonel();

                t.Ad = TxtAd.Text;
                t.Soyad = TxtSoyad.Text;
                t.Mail = TxtMail.Text;
                t.Departman = int.Parse(lookUpEdit2.EditValue.ToString());
                t.Durum = true;
                db.TblPersonel.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni Personel Başarı ile Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                personeller();


            }
            catch (Exception )
            {

                XtraMessageBox.Show("Geçersiz Personel Ekleme", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );


            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(TxtID.Text);
            var deger = db.TblPersonel.Find(x);
            deger.Durum = false;
            db.SaveChanges();

            XtraMessageBox.Show("Personel Başarı ile Silindi,Silinen Personeller Listesinden Silinmiş Tüm Personellerin Bilgilerine Ulaşabilirsiniz.. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personeller();

        }

   
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
           
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x=int.Parse(TxtID.Text);
            var deger = db.TblPersonel.Find(x);

            deger.Ad=TxtAd.Text;
            deger.Soyad=TxtSoyad.Text;
            deger.Mail=TxtMail.Text;
            deger.Görsel = TxtMail.Text;
            deger.Departman = int.Parse(lookUpEdit2.EditValue.ToString());

            db.SaveChanges();

            XtraMessageBox.Show("Personel Başarı İle Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            personeller();
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
        