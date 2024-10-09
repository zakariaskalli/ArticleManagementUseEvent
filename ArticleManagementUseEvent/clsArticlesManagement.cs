using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticleManagementUseEvent
{
    public class clsArticleData
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public clsArticleData(string Title, string Content)
        {
            this.Title = Title;
            this.Content = Content;

            clsGlobalData.NumIncrementedID++;
        }
    }

    public class clsArticles
    {
        public event EventHandler<clsArticleData> Published;

        public void PublishArticle(string Title, string Content)
        {

            RaiseOnPublished(new clsArticleData(Title, Content));
        }

        protected virtual void RaiseOnPublished(clsArticleData Article)
        {
            Published?.Invoke(this, Article);
        }
    }

    public class clsPublishArticles
    {
        public DataTable DT { get; set; } = new DataTable();
        public DataGridView dgv { get; set; }
        //public DataTable MyAllData { get; set; }
        public Label lblNumRecords { get; set; }

        public clsPublishArticles(DataGridView DataGrid, Label lblNumRecords)
        {
            this.dgv = DataGrid;
           this.lblNumRecords = lblNumRecords;
        }

        public void Subscribe(clsArticles Article)
        {
            Article.Published += AddAricleToDataGridView;
        }

        public void DiSubscribe(clsArticles Article)
        {
            Article.Published -= AddAricleToDataGridView;
        }

        private void AddAricleToDataGridView(object sender, clsArticleData Article)
        {
            if (dgv.InvokeRequired)
            {
                // Invoke on the UI thread
                dgv.Invoke(new Action(() => AddAricleToDataGridView(sender, Article)));
                return;
            }

            if (DT.Rows.Count == 0)
            {

                DT.Columns.Add("ID", typeof(int)); // Name and header text with int type
                DT.Columns.Add("Title", typeof(string)); // Name and header text
                DT.Columns.Add("Content", typeof(string)); // Name and header text
            }

            DT.Rows.Add(clsGlobalData.NumIncrementedID, Article.Title.ToString(), Article.Content.ToString());
            dgv.DataSource = DT;
            dgv.Refresh();
            lblNumRecords.Text = "Rocords: " + dgv.Rows.Count.ToString();
            //dgv.Refresh();
        }

    }



}
