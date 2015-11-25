namespace VirtuosoQueryData
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.btnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportCSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportJson = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportHtml = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportText = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMainMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnRun = new DevExpress.XtraBars.BarButtonItem();
            this.gallerySources = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.chkDBpedia = new DevExpress.XtraBars.BarCheckItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.chkIMDB = new DevExpress.XtraBars.BarCheckItem();
            this.chkGeoData = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.chkEurostat = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageMainGroupSource = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageMainGroupActivities = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageMainGroupExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.grdvwData = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvwData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Caption = "Excel";
            this.btnExportExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Glyph")));
            this.btnExportExcel.Id = 2;
            this.btnExportExcel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.LargeGlyph")));
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportExcel_ItemClick);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Caption = "CSV";
            this.btnExportCSV.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExportCSV.Glyph")));
            this.btnExportCSV.Id = 5;
            this.btnExportCSV.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExportCSV.LargeGlyph")));
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportCSV_ItemClick);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Caption = "JSON";
            this.btnExportJson.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExportJson.Glyph")));
            this.btnExportJson.Id = 3;
            this.btnExportJson.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExportJson.LargeGlyph")));
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnExportJson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportJson_ItemClick);
            // 
            // btnExportHtml
            // 
            this.btnExportHtml.Caption = "HTML";
            this.btnExportHtml.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExportHtml.Glyph")));
            this.btnExportHtml.Id = 4;
            this.btnExportHtml.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExportHtml.LargeGlyph")));
            this.btnExportHtml.Name = "btnExportHtml";
            this.btnExportHtml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportHtml_ItemClick);
            // 
            // btnExportText
            // 
            this.btnExportText.Caption = "Text";
            this.btnExportText.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExportText.Glyph")));
            this.btnExportText.Id = 6;
            this.btnExportText.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExportText.LargeGlyph")));
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportText_ItemClick);
            // 
            // ribbonMainMenu
            // 
            this.ribbonMainMenu.ExpandCollapseItem.Id = 0;
            this.ribbonMainMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonMainMenu.ExpandCollapseItem,
            this.btnRun,
            this.gallerySources,
            this.chkDBpedia,
            this.barToggleSwitchItem1,
            this.chkIMDB,
            this.chkGeoData,
            this.barButtonItem1,
            this.chkEurostat});
            this.ribbonMainMenu.Location = new System.Drawing.Point(0, 0);
            this.ribbonMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonMainMenu.MaxItemId = 9;
            this.ribbonMainMenu.Name = "ribbonMainMenu";
            this.ribbonMainMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMain});
            this.ribbonMainMenu.Size = new System.Drawing.Size(1356, 162);
            // 
            // btnRun
            // 
            this.btnRun.Caption = "Run SPARQL";
            this.btnRun.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRun.Glyph")));
            this.btnRun.Id = 8;
            this.btnRun.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRun.LargeGlyph")));
            this.btnRun.Name = "btnRun";
            this.btnRun.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRun.Tag = "http://www.dbpedia.org/sparql";
            this.btnRun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRun_ItemClick);
            // 
            // gallerySources
            // 
            this.gallerySources.Caption = "gallerySources";
            // 
            // 
            // 
            this.gallerySources.Gallery.AllowHoverImages = true;
            this.gallerySources.Gallery.ColumnCount = 3;
            galleryItemGroup1.Caption = "galleryGroupSources";
            this.gallerySources.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.gallerySources.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.Vertical;
            this.gallerySources.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.gallerySources.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.TopCenter;
            this.gallerySources.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.gallerySources.Gallery.ItemSize = new System.Drawing.Size(100, 60);
            this.gallerySources.Gallery.ShowItemText = true;
            this.gallerySources.Id = 1;
            this.gallerySources.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Immediate;
            this.gallerySources.Name = "gallerySources";
            // 
            // chkDBpedia
            // 
            this.chkDBpedia.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.chkDBpedia.BindableChecked = true;
            this.chkDBpedia.Caption = "DBpedia";
            this.chkDBpedia.Checked = true;
            this.chkDBpedia.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkDBpedia.Glyph = ((System.Drawing.Image)(resources.GetObject("chkDBpedia.Glyph")));
            this.chkDBpedia.GroupIndex = 1;
            this.chkDBpedia.Id = 2;
            this.chkDBpedia.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkDBpedia.LargeGlyph")));
            this.chkDBpedia.Name = "chkDBpedia";
            this.chkDBpedia.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkDBpedia.Tag = "http://dbpedia.org/sparql";
            this.chkDBpedia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSource_ItemClick);
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 3;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // chkIMDB
            // 
            this.chkIMDB.Caption = "IMDB";
            this.chkIMDB.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkIMDB.Glyph = global::VirtuosoQueryData.Properties.Resources.imdb_small;
            this.chkIMDB.GroupIndex = 1;
            this.chkIMDB.Id = 4;
            this.chkIMDB.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("chkIMDB.LargeGlyph")));
            this.chkIMDB.Name = "chkIMDB";
            this.chkIMDB.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkIMDB.Tag = "http://data.linkedmdb.org/sparql";
            this.chkIMDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSource_ItemClick);
            // 
            // chkGeoData
            // 
            this.chkGeoData.Caption = "GeoData";
            this.chkGeoData.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkGeoData.Glyph = global::VirtuosoQueryData.Properties.Resources.GeoData;
            this.chkGeoData.GroupIndex = 1;
            this.chkGeoData.Id = 5;
            this.chkGeoData.LargeGlyph = global::VirtuosoQueryData.Properties.Resources.GeoData_small;
            this.chkGeoData.Name = "chkGeoData";
            this.chkGeoData.Tag = "http://linkedgeodata.org/sparql";
            this.chkGeoData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSource_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // chkEurostat
            // 
            this.chkEurostat.Caption = "Eurostat";
            this.chkEurostat.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkEurostat.Glyph = global::VirtuosoQueryData.Properties.Resources.Eurostat_small;
            this.chkEurostat.GroupIndex = 1;
            this.chkEurostat.Id = 7;
            this.chkEurostat.LargeGlyph = global::VirtuosoQueryData.Properties.Resources.Eurostat;
            this.chkEurostat.Name = "chkEurostat";
            this.chkEurostat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkEurostat.Tag = "http://eurostat.linked-statistics.org/sparql";
            this.chkEurostat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSource_ItemClick);
            // 
            // ribbonPageMain
            // 
            this.ribbonPageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageMainGroupSource,
            this.ribbonPageMainGroupActivities,
            this.ribbonPageMainGroupExport});
            this.ribbonPageMain.Name = "ribbonPageMain";
            this.ribbonPageMain.Text = "Main";
            // 
            // ribbonPageMainGroupSource
            // 
            this.ribbonPageMainGroupSource.ItemLinks.Add(this.chkDBpedia);
            this.ribbonPageMainGroupSource.ItemLinks.Add(this.chkIMDB);
            this.ribbonPageMainGroupSource.ItemLinks.Add(this.chkGeoData);
            this.ribbonPageMainGroupSource.Name = "ribbonPageMainGroupSource";
            this.ribbonPageMainGroupSource.Text = "Select service";
            // 
            // ribbonPageMainGroupActivities
            // 
            this.ribbonPageMainGroupActivities.ItemLinks.Add(this.btnRun);
            this.ribbonPageMainGroupActivities.Name = "ribbonPageMainGroupActivities";
            this.ribbonPageMainGroupActivities.Text = "Activities";
            // 
            // ribbonPageMainGroupExport
            // 
            this.ribbonPageMainGroupExport.ItemLinks.Add(this.btnExportExcel);
            this.ribbonPageMainGroupExport.ItemLinks.Add(this.btnExportCSV);
            this.ribbonPageMainGroupExport.ItemLinks.Add(this.btnExportJson);
            this.ribbonPageMainGroupExport.ItemLinks.Add(this.btnExportHtml);
            this.ribbonPageMainGroupExport.ItemLinks.Add(this.btnExportText);
            this.ribbonPageMainGroupExport.Name = "ribbonPageMainGroupExport";
            this.ribbonPageMainGroupExport.Text = "Export Data";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 162);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.txtQuery);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdData);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1356, 734);
            this.splitContainerControl1.SplitterPosition = 140;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1356, 140);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.Text = "";
            // 
            // grdData
            // 
            this.grdData.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.grdData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.First.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.MainView = this.grdvwData;
            this.grdData.Margin = new System.Windows.Forms.Padding(4);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(1356, 588);
            this.grdData.TabIndex = 1;
            this.grdData.UseEmbeddedNavigator = true;
            this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvwData});
            // 
            // grdvwData
            // 
            this.grdvwData.GridControl = this.grdData;
            this.grdvwData.Name = "grdvwData";
            this.grdvwData.OptionsView.ShowFooter = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 896);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMain";
            this.ShowIcon = false;
            this.Text = "Virtuoso Query Data Tool";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvwData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvwData;
        private System.Windows.Forms.RichTextBox txtQuery;
        private DevExpress.XtraBars.BarButtonItem btnExportExcel;
        private DevExpress.XtraBars.BarButtonItem btnExportJson;
        private DevExpress.XtraBars.BarButtonItem btnExportHtml;
        private DevExpress.XtraBars.BarButtonItem btnExportCSV;
        private DevExpress.XtraBars.BarButtonItem btnExportText;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonMainMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageMainGroupExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageMainGroupSource;
        private DevExpress.XtraBars.BarButtonItem btnRun;
        private DevExpress.XtraBars.RibbonGalleryBarItem gallerySources;
        private DevExpress.XtraBars.BarCheckItem chkDBpedia;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarCheckItem chkIMDB;
        private DevExpress.XtraBars.BarCheckItem chkGeoData;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageMainGroupActivities;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem chkEurostat;

    }
}

