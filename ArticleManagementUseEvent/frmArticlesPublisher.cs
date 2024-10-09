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
using ArticleManagementUseEvent;

namespace ArticleManagementUseEvent
{
     

    public partial class frmArticlesPublisher : Form
    {
        public frmArticlesPublisher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmPublishANewArticle();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowArticles();
            frm.ShowDialog();
        }

        private void frmArticlesPublisher_Load(object sender, EventArgs e)
        {

        }
    }
}
