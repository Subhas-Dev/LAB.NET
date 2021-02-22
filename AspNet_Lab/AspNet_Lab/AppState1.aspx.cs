using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet_Lab
{
    public partial class AppState1 : System.Web.UI.Page
    {
        //1.Application State variables are available across all pages and across all sessions.
        //Application state variables are like muti-user golobal data.
        //2. Application State variables are stored on the web server
        //3. Application state variables are cleared, when the pocess hosting the application is restarted.

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Application["vsNum"] == null)
                {
                    Application["vsNum"] = 0;
                }
                txtNum.Text = Application["vsNum"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clicksCount = (int)Application["vsNum"] + 1;
            txtNum.Text = clicksCount.ToString();
            Application["vsNum"] = clicksCount;

        }
    }
}