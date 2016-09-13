using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using SmartMethodStore;

namespace SmartMethodStore
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            using (StoreDataContext Data = new StoreDataContext())
            {
                Exception ExceptionToLog = Server.GetLastError();
                Error NewError = new Error();
                NewError.ErrorMessage = ExceptionToLog.Message;
                NewError.ErrorStackTrace = ExceptionToLog.StackTrace;
                NewError.ErrorURL = Request.Url.ToString();
                NewError.ErrorDate = DateTime.Now;
                Data.Errors.InsertOnSubmit(NewError);
                Data.SubmitChanges();
            }
            Response.Redirect("~/error.aspx");
        }
    }
}
