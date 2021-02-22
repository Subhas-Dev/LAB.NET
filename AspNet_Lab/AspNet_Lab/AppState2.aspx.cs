using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet_Lab
{
    public partial class AppState2 : System.Web.UI.Page
    {
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