using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet_Lab
{
    public partial class SessionState2 : System.Web.UI.Page
    {
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