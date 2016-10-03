using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StableBase
{
    public partial class TaskAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Lazy<StableBaseDataContext> Data = new Lazy<StableBaseDataContext>();

        protected void ButtonAddNewTask_Click(object sender, EventArgs e)
        {
            if (TextBoxNewTaskName.Text.Length > 0)
            {
                Task NewTask = new Task();
                NewTask.TaskName = TextBoxNewTaskName.Text;
                Data.Value.Tasks.InsertOnSubmit(NewTask);
                Data.Value.SubmitChanges();
                GridViewTask.DataBind();
            }
        }
    }
}