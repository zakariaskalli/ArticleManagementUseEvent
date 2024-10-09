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
    public partial class frmShowArticles : Form
    {

        public frmShowArticles()
        {
            InitializeComponent();

        }



        private void frmShowArticles_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = clsGlobalData.AllArticlesDataTabel;
            dgv1.Refresh();
            lblNumRecords.Text = "Rocords: " + dgv1.Rows.Count.ToString();
        }
    }
}
