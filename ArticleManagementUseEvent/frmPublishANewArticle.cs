using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArticleManagementUseEvent
{
    public partial class frmPublishANewArticle : Form
    {
        public frmPublishANewArticle()
        {
            InitializeComponent();
        }

        void AddDataToDataTable(string Title, string Content)
        {
            if (clsGlobalData.AllArticlesDataTabel.Rows.Count == 0)
            {

                clsGlobalData.AllArticlesDataTabel.Columns.Add("ID", typeof(int)); // Name and header text with int type
                clsGlobalData.AllArticlesDataTabel.Columns.Add("Title", typeof(string)); // Name and header text
                clsGlobalData.AllArticlesDataTabel.Columns.Add("Content", typeof(string)); // Name and header text
            }

            clsGlobalData.AllArticlesDataTabel.Rows.Add(clsGlobalData.NumIncrementedID, Title, Content);
            
            //dgv.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string Title = tbTitle.Text;
            string Content = tbContent.Text;

            clsGlobalData.MyGlobalArticle.PublishArticle(Title, Content);

            AddDataToDataTable(Title, Content);



            this.Close();
        }
    }
}
