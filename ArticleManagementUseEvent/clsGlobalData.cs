using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleManagementUseEvent
{
    public static class clsGlobalData
    {

        public static clsArticles MyGlobalArticle = new clsArticles();
        public static int NumIncrementedID = 0;
        public static DataTable AllArticlesDataTabel = new DataTable();
    }
}
