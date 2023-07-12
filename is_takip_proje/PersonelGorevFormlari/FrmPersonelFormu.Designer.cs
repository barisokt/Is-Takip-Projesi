namespace is_takip_proje.PersonelGorevFormlari
{
    partial class FrmPersonelFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelFormu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAktifGörevler = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTamamlanmisGörevler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCagriListesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnAktifGörevler,
            this.barButtonItem2,
            this.barButtonItem3,
            this.BtnTamamlanmisGörevler,
            this.BtnCagriListesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1278, 183);
            // 
            // BtnAktifGörevler
            // 
            this.BtnAktifGörevler.Caption = "Aktif Görevler";
            this.BtnAktifGörevler.Id = 1;
            this.BtnAktifGörevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAktifGörevler.ImageOptions.Image")));
            this.BtnAktifGörevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAktifGörevler.ImageOptions.LargeImage")));
            this.BtnAktifGörevler.Name = "BtnAktifGörevler";
            this.BtnAktifGörevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAktifGörevler_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // BtnTamamlanmisGörevler
            // 
            this.BtnTamamlanmisGörevler.Caption = "Tamamlanmış Görevler";
            this.BtnTamamlanmisGörevler.Id = 4;
            this.BtnTamamlanmisGörevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTamamlanmisGörevler.ImageOptions.Image")));
            this.BtnTamamlanmisGörevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnTamamlanmisGörevler.ImageOptions.LargeImage")));
            this.BtnTamamlanmisGörevler.Name = "BtnTamamlanmisGörevler";
            this.BtnTamamlanmisGörevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // BtnCagriListesi
            // 
            this.BtnCagriListesi.Caption = "Çağrı Listesi";
            this.BtnCagriListesi.Id = 5;
            this.BtnCagriListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCagriListesi.ImageOptions.Image")));
            this.BtnCagriListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCagriListesi.ImageOptions.LargeImage")));
            this.BtnCagriListesi.Name = "BtnCagriListesi";
            this.BtnCagriListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAktifGörevler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnTamamlanmisGörevler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnCagriListesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // FrmPersonelFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 563);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmPersonelFormu";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FrmPersonelFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnAktifGörevler;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem BtnTamamlanmisGörevler;
        private DevExpress.XtraBars.BarButtonItem BtnCagriListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}