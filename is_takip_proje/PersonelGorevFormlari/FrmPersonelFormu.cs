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
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }



        public string mail;

        PersonelGorevFormlari.FrmTamamlanmisGorevler frm;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm== null || frm.IsDisposed) { 
            frm=new PersonelGorevFormlari.FrmTamamlanmisGorevler();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
            }
        }

        PersonelGorevFormlari.FrmAktifGörevler frm6;
        private void BtnAktifGörevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm6 == null || frm6.IsDisposed) { 
        frm6 = new PersonelGorevFormlari.FrmAktifGörevler();
            frm6.MdiParent = this;
            frm6.mail2 = mail;
            frm6.Show();
        }

    }

        private void FrmPersonelFormu_Load(object sender, EventArgs e)
        {
            //this.Text = mail.ToString();
            this.Text = "Personel Formu";
        }

        PersonelGorevFormlari.FrmCagriListesi frm1;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new PersonelGorevFormlari.FrmCagriListesi();
                frm1.MdiParent = this;
                frm1.mail2 = mail;
                frm1.Show();
            }
        }
    }
}
