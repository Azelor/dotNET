using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StableBase
{
    public partial class GetPicture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["HorseID"] != null)
            {
                int HorseID = Convert.ToInt32(Request.QueryString["HorseID"]);
                using (StableBaseDataContext Data = new StableBaseDataContext())
                {
                    Horse HorseForImage = Data.Horses.Single(Horse => Horse.HorseID == HorseID);
                    if (HorseForImage.HorsePicture != null)
                    {
                        byte[] ImageBytes = HorseForImage.HorsePicture.ToArray();
                        Response.ContentType = "image/jpeg";
                        Response.BinaryWrite(ImageBytes);
                        Response.End();
                    }
                }
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}