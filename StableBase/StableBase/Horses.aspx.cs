using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StableBase
{
    public partial class Horses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewHorse_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            PanelScreenMask.Visible = true;
            if (e.CommandName == "ViewDetails")
            {
                PanelHorseDetails.Visible = true;
                int RowClicked = Convert.ToInt32(e.CommandArgument);
                int HorseID = Convert.ToInt32(GridViewHorse.DataKeys[RowClicked].Value);
                using (StableBaseDataContext Data = new StableBaseDataContext())
                {
                    Horse HorseToDisplay = Data.Horses.Single(Horse => Horse.HorseID == HorseID);
                    LabelHorseName.Text = HorseToDisplay.HorseName;
                    LabelHorseSize.Text = HorseToDisplay.HorseSize.ToString("0.00");
                    LabelHorseWeight.Text = HorseToDisplay.HorseWeight.ToString("0.00");

                    if (HorseToDisplay.HorsePicture != null)
                    {
                        ImageHorsePicture.ImageUrl = "~/GetPicture.aspx?HorseID=" + HorseToDisplay.HorseID;
                    }
                    else
                    {
                        ImageHorsePicture.ImageUrl = "~/Images/NoPic.jpg";
                    }

                    FormatProficiencyBar(PanelRidingSchoolProficiency, HorseToDisplay.HorseRidingSchool);
                    FormatProficiencyBar(PanelShowJumpingProficiency, HorseToDisplay.HorseShowJumping);
                    FormatProficiencyBar(PanelDressageProficiency, HorseToDisplay.HorseDressage);
                    FormatProficiencyBar(PanelRacingProficiency, HorseToDisplay.HorseRacing);
                }
            }
            else if (e.CommandName == "ViewChecklist")
            {
                PanelHorseChecklist.Visible = true;
                int RowClicked = Convert.ToInt32(e.CommandArgument);
                int HorseID = Convert.ToInt32(GridViewHorse.DataKeys[RowClicked].Value);

                using (StableBaseDataContext Data = new StableBaseDataContext())
                {
                    Horse HorseToDisplay = Data.Horses.Single(Horse => Horse.HorseID == HorseID);
                    LabelChecklistHorseName.Text = HorseToDisplay.HorseName;
                    var HorseTasksMorning = Data.HorseTasks
                                                .Where(HorseTask => (HorseTask.HorseTaskIsDaily == true || (HorseTask.HorseTaskStartDate <= DateTime.Today && HorseTask.HorseTaskEndDate >= DateTime.Today)) && HorseTask.HorseTaskIsMorning == true && HorseTask.Horse.HorseID == HorseID)
                                                .Select(HorseTask => new { HorseTask.Task.TaskName, HorseTask.HorseTaskNotes });
                    GridViewChecklistMorning.DataSource = HorseTasksMorning;
                    GridViewChecklistMorning.DataBind();

                    var HorseTasksEvening = Data.HorseTasks
                                .Where(HorseTask => (HorseTask.HorseTaskIsDaily == true || (HorseTask.HorseTaskStartDate <= DateTime.Today && HorseTask.HorseTaskEndDate >= DateTime.Today)) && HorseTask.HorseTaskIsMorning == false && HorseTask.Horse.HorseID == HorseID)
                                .Select(HorseTask => new { HorseTask.Task.TaskName, HorseTask.HorseTaskNotes });
                    GridViewChecklistEvening.DataSource = HorseTasksEvening;
                    GridViewChecklistEvening.DataBind();
                }
            }
        }

        private void FormatProficiencyBar(Panel BarToColor, decimal ProficiencyLevel)
        {
            BarToColor.Width = (Unit)(ProficiencyLevel * 2);
            if (ProficiencyLevel >= 50)
            {
                BarToColor.BackColor = System.Drawing.Color.Green;
            }
            else if (ProficiencyLevel >= 25)
            {
                BarToColor.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                BarToColor.BackColor = System.Drawing.Color.Red;
            }
        }

        protected void LinkButtonCloseHorseDetailsPanel_Click(object sender, EventArgs e)
        {
            PanelHorseDetails.Visible = false;
            PanelScreenMask.Visible = false;
        }

        protected void LinkButtonCloseChecklist_Click(object sender, EventArgs e)
        {
            PanelHorseChecklist.Visible = false;
            PanelScreenMask.Visible = false;
        }

        protected void LinkButtonEditHorseDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HorseAdmin.aspx");
        }

        protected void LinkButtonEditCheckList_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ScheduleAdmin.aspx");
        }
    }
}