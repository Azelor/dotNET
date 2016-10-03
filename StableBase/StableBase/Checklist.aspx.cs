using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StableBase
{
    public partial class Checklist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (StableBaseDataContext Data = new StableBaseDataContext())
            {
                var HorseTasksMorning = Data.HorseTasks
                                            .Where(HorseTask => (HorseTask.HorseTaskIsDaily == true || (HorseTask.HorseTaskStartDate <= DateTime.Today && HorseTask.HorseTaskEndDate >= DateTime.Today)) && HorseTask.HorseTaskIsMorning == true)
                                            .Select(HorseTask => new { HorseTask.Horse.HorseName, HorseTask.Task.TaskName, HorseTask.HorseTaskNotes });
                GridViewMorning.DataSource = HorseTasksMorning;
                GridViewMorning.DataBind();

                var HorseTasksEvening = Data.HorseTasks
                            .Where(HorseTask => (HorseTask.HorseTaskIsDaily == true || (HorseTask.HorseTaskStartDate <= DateTime.Today && HorseTask.HorseTaskEndDate >= DateTime.Today)) && HorseTask.HorseTaskIsMorning == false)
                            .Select(HorseTask => new { HorseTask.Horse.HorseName, HorseTask.Task.TaskName, HorseTask.HorseTaskNotes });
                GridViewEvening.DataSource = HorseTasksEvening;
                GridViewEvening.DataBind();
            }
        }
    }
}