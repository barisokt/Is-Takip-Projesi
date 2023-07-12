using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using is_takip_proje.Entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace is_takip_proje.Formlar
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class FrmDepartmanlar : Form
    {
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }

        // ekleme çıkarma güncelleme 


        DbisTakipEntities db = new DbisTakipEntities();

        void Listele()
        {




            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {
                                x.ID,
                                x.Ad


                            }).ToList();

            gridControl1.DataSource = degerler;




        }


        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                TblDepartmanlar t = new TblDepartmanlar();

                t.Ad = TxtAd.Text;
                t.ID = int.Parse(TxtID.Text);
                db.TblDepartmanlar.Add(t);
                db.SaveChanges();

                XtraMessageBox.Show("Departman başarılı bir şekilde sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                Listele();

            }
            catch (Exception ) 
            {

                XtraMessageBox.Show("Geçersiz Departman Ekleme", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            

            }
            
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblDepartmanlar.Find(x);
            db.TblDepartmanlar.Remove(deger);

            db.SaveChanges();

            XtraMessageBox.Show("Departman Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            Listele();
        }

 

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

            int x = int.Parse(TxtID.Text);
            var deger = db.TblDepartmanlar.Find(x);

            deger.Ad=TxtAd.Text;

            db.SaveChanges();   

            XtraMessageBox.Show("Departman Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Listele();

        }

        private void FrmDepartmanlar_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();

        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {

        }
    }
}
