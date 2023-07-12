using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using is_takip_proje.Entity;

namespace is_takip_proje
{
  
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }
        Formlar.FrmDepartmanlar frm;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm == null || frm.IsDisposed)
            {

                frm = new Formlar.FrmDepartmanlar();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        Formlar.FrmPersoneller frm2;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm2 == null || frm2.IsDisposed)
            {

                frm2 = new Formlar.FrmPersoneller();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }


       






        Formlar.FrmPersonelİstatistik frm3;
        private void BtnPersonelİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.FrmPersonelİstatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        Formlar.FrmGörevListesi frm4;
        private void BtnGörevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed) { 

           frm4= new Formlar.FrmGörevListesi();
            frm4.MdiParent = this;
            frm4.Show();
        }
    }

        private void BtnGörevTanımla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGörev fr = new Formlar.FrmGörev();
            fr.Show();
        }

        private void BtnGörevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetaylar  fr=new Formlar.FrmGorevDetaylar();
            fr.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonelEkle fr = new Formlar.FrmPersonelEkle();
            fr.Show();
        }
        Formlar.FrmAnaForm frm5;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Formlar.FrmAnaForm();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
        Formlar.AktifCagrilar fr;
        private void BtnAktifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         //= new Formlar.AktifCagrilar();
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.AktifCagrilar();
                fr.MdiParent = this;
                fr.Show();
            }

        }
        Formlar.AktifGorevler frm7;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {

                frm7 = new Formlar.AktifGorevler();
                frm7.MdiParent = this;
                frm7.Show();

            }
           


        }
        Formlar.TamamlananGorevler frm8;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm8 == null || frm8.IsDisposed)
            {
                frm8 = new Formlar.TamamlananGorevler();
                frm8.MdiParent = this;
                frm8.Show();

            }
        }
        Formlar.TamamlanmisCagrilar frm9;
        private void BtnTamamlanmisCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new Formlar.TamamlanmisCagrilar();
                frm9.MdiParent = this;
                frm9.Show();

            }


        }
        Formlar.SilinmisPersoneller frm10;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm10== null || frm10.IsDisposed)
            {
                frm10=new Formlar.SilinmisPersoneller();
                frm10.MdiParent = this;
                frm10.Show();

            }


        }
        Formlar.FrmFirmaListesi frm11;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm11 == null || frm11.IsDisposed)
            {
                frm11 = new Formlar.FrmFirmaListesi();
                frm11.MdiParent = this;
                frm11.Show();

            }


        }
        Formlar.FrmFirmaEkle frm12;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Formlar.FrmFirmaEkle();
                frm12.Show();

            }

        }
       
     
     
        Formlar.Departmanİstatistik frm13;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm13 == null || frm13.IsDisposed)
            {
                frm13 = new Formlar.Departmanİstatistik();
                frm13.MdiParent = this;
                frm13.Show();

            }
        }
        Formlar.FrmFirmİstatistik frm14;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm14 == null || frm14.IsDisposed)
            {

                frm14 = new Formlar.FrmFirmİstatistik();
                frm14.MdiParent = this;
                frm14.Show();
            }

        }
        Formlar.FrmGorevİstatistik frm15;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm15 == null || frm15.IsDisposed)
            {
                frm15=new Formlar.FrmGorevİstatistik(){MdiParent = this};
                frm15.Show();

            }

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcessStartInfo youtube = new ProcessStartInfo("https://www.youtube.com/");
            Process.Start(youtube);
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ProcessStartInfo hesapmakinesi = new ProcessStartInfo("https://hesapmakinesi.com/");
            Process.Start(hesapmakinesi);
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcessStartInfo haberler = new ProcessStartInfo("https://www.haberler.com/");
            Process.Start(haberler);
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcessStartInfo kurlar = new ProcessStartInfo("https://www.haberler.com/finans/");
            Process.Start(kurlar);
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcessStartInfo haritalar = new ProcessStartInfo("https://www.google.com/maps");
            Process.Start(haritalar);
        }
    }
}
