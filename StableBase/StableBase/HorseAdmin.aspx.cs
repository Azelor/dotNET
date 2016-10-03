using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StableBase
{
    public partial class HorseAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownListHorse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListHorse.SelectedValue != "0")
            {
                PanelHorseDetails.Visible = true;
                DropDownListHorse.Enabled = false;
                ButtonAddNewHorse.Enabled = false;
                ButtonSave.Visible = true;
                ButtonSaveNewHorse.Visible = false;
                using (StableBaseDataContext Data = new StableBaseDataContext())
                {
                    Horse HorseToEdit = Data.Horses.Single(H => H.HorseID == Convert.ToInt32(DropDownListHorse.SelectedValue));
                    TextBoxHorseName.Text = HorseToEdit.HorseName;
                    TextBoxHorseSize.Text = HorseToEdit.HorseSize.ToString("0.00");
                    TextBoxHorseWeight.Text = HorseToEdit.HorseWeight.ToString("0.00");
                    TextBoxHorseRidingSchool.Text = HorseToEdit.HorseRidingSchool.ToString("0.00");
                    TextBoxHorseShowJumping.Text = HorseToEdit.HorseShowJumping.ToString("0.00");
                    TextBoxHorseDressage.Text = HorseToEdit.HorseDressage.ToString("0.00");
                    TextBoxHorseRacing.Text = HorseToEdit.HorseRacing.ToString("0.00");
                    if (HorseToEdit.HorsePicture != null)
                    {
                        ImageHorsePicture.ImageUrl = "~/GetPicture.aspx?HorseID=" + HorseToEdit.HorseID;
                    }
                    else
                    {
                        ImageHorsePicture.ImageUrl = "~/Images/NoPic.jpg";
                    }
                }
            }
            else
            {
                PanelHorseDetails.Visible = false;
                DropDownListHorse.Enabled = true;
                ButtonAddNewHorse.Enabled = true;
            }
        }

        protected void ButtonAddNewHorse_Click(object sender, EventArgs e)
        {
            PanelHorseDetails.Visible = true;
            DropDownListHorse.Enabled = false;
            ButtonAddNewHorse.Enabled = false;
            ButtonSave.Visible = false;
            ButtonSaveNewHorse.Visible = true;
            TextBoxHorseName.Text = "";
            TextBoxHorseSize.Text = "";
            TextBoxHorseWeight.Text = "";
            TextBoxHorseRidingSchool.Text = "";
            TextBoxHorseShowJumping.Text = "";
            TextBoxHorseDressage.Text = "";
            TextBoxHorseRacing.Text = "";
            ImageHorsePicture.ImageUrl = "~/Images/NoPic.jpg";
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            DropDownListHorse.SelectedIndex = 0;
            PanelHorseDetails.Visible = false;
            DropDownListHorse.Enabled = true;
            ButtonAddNewHorse.Enabled = true;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            using (StableBaseDataContext Data = new StableBaseDataContext())
            {
                Horse HorseToEdit = Data.Horses.Single(H => H.HorseID == Convert.ToInt32(DropDownListHorse.SelectedValue));
                HorseToEdit.HorseName = TextBoxHorseName.Text;
                HorseToEdit.HorseSize = Convert.ToDecimal(TextBoxHorseSize.Text);
                HorseToEdit.HorseWeight = Convert.ToDecimal(TextBoxHorseWeight.Text);
                HorseToEdit.HorseRidingSchool = Convert.ToDecimal(TextBoxHorseRidingSchool.Text);
                HorseToEdit.HorseShowJumping = Convert.ToDecimal(TextBoxHorseShowJumping.Text);
                HorseToEdit.HorseDressage = Convert.ToDecimal(TextBoxHorseDressage.Text);
                HorseToEdit.HorseRacing = Convert.ToDecimal(TextBoxHorseRacing.Text);
                if (FileUploadHorsePicture.HasFile)
                {
                    HorseToEdit.HorsePicture = FileUploadHorsePicture.FileBytes;
                }
                Data.SubmitChanges();
            }
            DropDownListHorse.SelectedIndex = 0;
            PanelHorseDetails.Visible = false;
            DropDownListHorse.Enabled = true;
            ButtonAddNewHorse.Enabled = true;
        }

        protected void ButtonSaveNewHorse_Click(object sender, EventArgs e)
        {
            using (StableBaseDataContext Data = new StableBaseDataContext())
            {
                Horse NewHorse = new Horse();
                NewHorse.HorseName = TextBoxHorseName.Text;
                NewHorse.HorseSize = Convert.ToDecimal(TextBoxHorseSize.Text);
                NewHorse.HorseWeight = Convert.ToDecimal(TextBoxHorseWeight.Text);
                NewHorse.HorseRidingSchool = Convert.ToDecimal(TextBoxHorseRidingSchool.Text);
                NewHorse.HorseShowJumping = Convert.ToDecimal(TextBoxHorseShowJumping.Text);
                NewHorse.HorseDressage = Convert.ToDecimal(TextBoxHorseDressage.Text);
                NewHorse.HorseRacing = Convert.ToDecimal(TextBoxHorseRacing.Text);
                if (FileUploadHorsePicture.HasFile)
                {
                    NewHorse.HorsePicture = FileUploadHorsePicture.FileBytes;
                }
                Data.Horses.InsertOnSubmit(NewHorse);
                Data.SubmitChanges();
            }
            DropDownListHorse.SelectedIndex = 0;
            PanelHorseDetails.Visible = false;
            DropDownListHorse.Enabled = true;
            ButtonAddNewHorse.Enabled = true;
        }
    }
}