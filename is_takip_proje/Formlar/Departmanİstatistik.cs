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
    public partial class Departmanİstatistik : Form
    {
        public Departmanİstatistik()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void Departmanİstatistik_Load(object sender, EventArgs e)
        {
            var d1 = db.TblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
             LblAyinDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID == db.TblPersonel.Where(t => t.ID == d1).Select(z => z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
        }

        private void LblAyinDepartmani_Click(object sender, EventArgs e)
        {

        }

        private void LblToplamDepartman_Click(object sender, EventArgs e)
        {
          
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
