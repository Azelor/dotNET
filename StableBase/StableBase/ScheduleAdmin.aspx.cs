using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StableBase
{
    public partial class ScheduleAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("Memory usage before GetSchedule method: " + GC.GetTotalMemory(false) + "<br/>");
                GetSchedule();
                GC.Collect();
                Response.Write("Memory usage after GetSchedule method: " + GC.GetTotalMemory(false));
            }
        }

        private void GetSchedule()
        {
            using (StableBaseDataContext Data = new StableBaseDataContext())
            {
                List<TaskRow> TableRows = new List<TaskRow>();
                var HorseTasks = Data.HorseTasks.OrderBy(HorseTask => HorseTask.Horse.HorseName).ThenBy(HorseTask => HorseTask.Task.TaskName);
                foreach (HorseTask HorseTask in HorseTasks)
                {
                    TaskRow TableRow = new TaskRow();
                    TableRow.HorseTaskID = HorseTask.HorseTaskID;
                    TableRow.HorseName = HorseTask.Horse.HorseName;
                    TableRow.TaskName = HorseTask.Task.TaskName;
                    TableRow.TaskNotes = HorseTask.HorseTaskNotes;
                    if (HorseTask.HorseTaskIsMorning)
                    {
                        TableRow.TaskTime = "Morning";
                    }
                    else
                    {
                        TableRow.TaskTime = "Evening";
                    }
                    if (HorseTask.HorseTaskIsDaily)
                    {
                        TableRow.TaskInterval = "Every day";
                    }
                    else
                    {
                        TableRow.TaskInterval = "From " + ((DateTime)HorseTask.HorseTaskStartDate).ToString("dd MMM yyyy") + " to " + ((DateTime)HorseTask.HorseTaskEndDate).ToString("dd MMM yyyy");
                    }
                    TableRows.Add(TableRow);
                }
                GridViewHorseTask.DataSource = TableRows;
                GridViewHorseTask.DataBind();
            }
        }

        protected void CheckBoxIsDaily_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxIsDaily.Checked)
            {
                TextBoxStartDate.Text = "";
                TextBoxEndDate.Text = "";
                TextBoxStartDate.Enabled = false;
                TextBoxEndDate.Enabled = false;
            }
            else
            {
                TextBoxStartDate.Text = DateTime.Today.ToString("dd MMM yyyy");
                TextBoxEndDate.Text = DateTime.Today.ToString("dd MMM yyyy");
                TextBoxStartDate.Enabled = true;
                TextBoxEndDate.Enabled = true;
            }
        }

        protected void ButtonAddTask_Click(object sender, EventArgs e)
        {
            using (StableBaseDataContext Data = new StableBaseDataContext())
            {
                HorseTask NewTask = new HorseTask();
                NewTask.HorseID = Convert.ToInt32(DropDownListHorse.SelectedValue);
                NewTask.TaskID = Convert.ToInt32(DropDownListTask.SelectedValue);
                NewTask.HorseTaskIsDaily = CheckBoxIsDaily.Checked;
                NewTask.HorseTaskIsMorning = Convert.ToBoolean(DropDownListIsMorning.SelectedValue);
                NewTask.HorseTaskNotes = TextBoxTaskNotes.Text;
                Data.HorseTasks.InsertOnSubmit(NewTask);
                Data.SubmitChanges();

                GetSchedule();
            }
        }

        protected void GridViewHorseTask_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int RowClicked = Convert.ToInt32(e.CommandArgument);
            int HorseTaskID = Convert.ToInt32(GridViewHorseTask.DataKeys[RowClicked].Value);
            using (StableBaseDataContext Data = new StableBaseDataContext())
            {
                HorseTask TaskToDelete = Data.HorseTasks.Single(HorseTask => HorseTask.HorseTaskID == HorseTaskID);
                Data.HorseTasks.DeleteOnSubmit(TaskToDelete);
                Data.SubmitChanges();

                GetSchedule();
            }
        }
    }

    class TaskRow
    {
        public int HorseTaskID { get; set; }
        public string HorseName { get; set; }
        public string TaskName { get; set; }
        public string TaskNotes { get; set; }
        public string TaskTime { get; set; }
        public string TaskInterval { get; set; }
    }
}