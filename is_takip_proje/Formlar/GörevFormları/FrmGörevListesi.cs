using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmGörevListesi : Form
    {
        public FrmGörevListesi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmGörevListesi_Load(object sender, EventArgs e)
        {
              gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.ID,
                                           x.Aciklama

                                        }).ToList();

            LblAktifGörev.Text = db.TblGorevler.Where(x => x.Durum == true).Count().ToString();
            LblTamamlanmisGörev.Text = db.TblGorevler.Where(x => x.Durum == true).Count().ToString();
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(LblAktifGörev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Tamamlanmış Görevler",int.Parse(LblTamamlanmisGörev.Text));


        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
