using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StableBase
{
    public partial class NewsAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddNewsItem_Click(object sender, EventArgs e)
        {
            if (TextBoxNews.Text.Length > 0)
            {
                using (StableBaseDataContext Data = new StableBaseDataContext())
                {
                    New NewsItem = new New();
                    NewsItem.NewsText = TextBoxNews.Text;
                    NewsItem.NewsDate = DateTime.Now;
                    Data.News.InsertOnSubmit(NewsItem);
                    Data.SubmitChanges();
                }
            }
            PanelAddNews.Visible = false;
            PanelConfirm.Visible = true;
        }
    }
}