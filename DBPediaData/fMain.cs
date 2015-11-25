using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VirtuosoQueryData
{
    public partial class fMain : Form
    {
        private string _ServiceUrl = String.Empty;
        public fMain()
        {
            InitializeComponent();
        }


        private void barSource_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ServiceUrl = e.Item.Tag.ToString();
        }


        private void btnRun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ServiceUrl = string.IsNullOrEmpty(_ServiceUrl) ? this.chkDBpedia.Tag.ToString() : _ServiceUrl;

            this.grdData.DataSource = null;
            this.grdvwData.Columns.Clear();
            this.grdData.Refresh();

            if (string.IsNullOrEmpty(this.txtQuery.Text.ToLower().Trim())) return;

            VirtuosoQueryData.Sparql.Net.Query.Client client = new VirtuosoQueryData.Sparql.Net.Query.Client(_ServiceUrl);

            List<VirtuosoQueryData.Sparql.Net.Query.Result> results = new List<VirtuosoQueryData.Sparql.Net.Query.Result>();

            try
            {
                results = client.Query(new VirtuosoQueryData.Sparql.Net.Query.QueryBuilder(this.txtQuery.Text));
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
            }

            if (results.Count == 1)
            {
                this.grdData.DataSource = results[0].Detail.Data;
            }
            else
            {
                List<dynamic> a = new List<dynamic>();
                foreach (var res in results)
                {
                    a.AddRange(res.Detail.Data);
                }
                this.grdData.DataSource = a;
            }


        }

        private void btnExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export("Export Data (xlsx)", ExportType.xlsx);
        }

        private void btnExportCSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export("Export Data (csv)", ExportType.csv);
        }

        private void btnExportJson_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export("Export Data (json)", ExportType.json);
        }

        private void btnExportHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export("Export Data (html)", ExportType.html);
        }

        private void btnExportText_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export("Export Data (txt)", ExportType.txt);
        }

        private void Export(string caption, ExportType type)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog()
            {

                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true,
                Description = caption
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                switch (type)
                {
                    case ExportType.xlsx:
                        this.grdvwData.ExportToXlsx(string.Format("{0}/{1}.xlsx", folderDialog.SelectedPath, DateTime.Now.ToString("yyyyMMdd_HHmmss")));
                        break;
                    case ExportType.csv:
                        this.grdvwData.ExportToCsv(string.Format("{0}/{1}.csv", folderDialog.SelectedPath, DateTime.Now.ToString("yyyyMMdd_HHmmss")));
                        break;
                    case ExportType.html:
                        this.grdvwData.ExportToHtml(string.Format("{0}/{1}.html", folderDialog.SelectedPath, DateTime.Now.ToString("yyyyMMdd_HHmmss")));
                        break;
                    case ExportType.txt:
                        this.grdvwData.ExportToText(string.Format("{0}/{1}.txt", folderDialog.SelectedPath, DateTime.Now.ToString("yyyyMMdd_HHmmss")));
                        break;
                    case ExportType.json:
                        System.IO.File.AppendAllText(string.Format("{0}/{1}.js", folderDialog.SelectedPath, DateTime.Now.ToString("yyyyMMdd_HHmmss")), Newtonsoft.Json.JsonConvert.SerializeObject(this.grdData.DataSource));
                        break;
                }
            }
        }

    }

}
