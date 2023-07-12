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



namespace is_takip_proje.Formlar
{

   
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {

            TblPersonel t = new TblPersonel();


            var departmanlar = (from x in db.TblDepartmanlar
                                select new
                                {

                                    x.ID,
                                    x.Ad


                                }).ToList();

            lookUpEdit1.Properties.ValueMember = ("ID");
            lookUpEdit1.Properties.DisplayMember = ("Ad");
            lookUpEdit1.Properties.DataSource = departmanlar;

        
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblPersonel c = new TblPersonel();
            c.Ad = TxtPersonelAd.Text;
            c.Soyad = TxtPersonelSoyad.Text;
            c.Mail = TxtPersonelMail.Text;
            c.Departman=int.Parse(lookUpEdit1.EditValue.ToString());
            c.Durum = true;
            db.TblPersonel.Add(c);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Personel Başarı ile Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();    
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
