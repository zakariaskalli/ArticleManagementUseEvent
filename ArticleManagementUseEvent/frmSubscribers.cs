using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticleManagementUseEvent
{
    public partial class frmSubscribers : Form
    {
        private int FormNum { get; set; }

        clsPublishArticles Article;

        public frmSubscribers(int FromNum)
        {
            InitializeComponent();
            this.FormNum = FromNum;

            Article = new clsPublishArticles(dgv1, lblNumRecords);
        }

        private void SubscriberOne_Load(object sender, EventArgs e)
        {
            lblSubscriberNum.Text = FormNum.ToString();
            this.Text = $"Subscribe {FormNum}";


        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {

            Article.Subscribe(clsGlobalData.MyGlobalArticle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Article.DiSubscribe(clsGlobalData.MyGlobalArticle);

        }
    }
}
