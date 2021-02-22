using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet_Lab
{
    public partial class SessionState1 : System.Web.UI.Page
    {
        //Using Session State Variable
        //Session state data is available across all forms
        // In web config <sessionState mode="InProc" cookieless="true"> 
        //means we are telling Web Server not to use cookies for sessions any more. Instead use session id as part of the url.
        // https://localhost:44337/(S(duokwrp4bwcvvzbrlb0z4tki))/SessionState1
        //<sessionState mode = "InProc" cookieless="true" timeout="1"></sessionState>
        // Session state variables are available across all pages, but only for  given single seesion. Session variable are like single-user global data
        //Session variables are cleared, when the user session times out. The default session is 20 minutes and this configurable in web.config.


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["vsNum"] == null)
                {
                    Session["vsNum"] = 0;
                }
                txtNum.Text = Session["vsNum"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clicksCount = (int)Session["vsNum"] + 1;
            txtNum.Text = clicksCount.ToString();
            Session["vsNum"] = clicksCount;

        }
    }
}