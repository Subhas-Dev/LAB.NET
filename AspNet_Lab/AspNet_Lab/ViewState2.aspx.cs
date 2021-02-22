using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet_Lab
{
    public partial class ViewState2 : System.Web.UI.Page
    {
        // ViewState of form1 is not available in form2.
        //ViewState of a form is available only on within that form.
        //ViewState is stored on the page in a hidden field called _ViewSate. Because of this , the view state of this, the Viewstate, will be lost, 
        //if you navigate away from the page, or if the browser is closed.
        // ViewState is retain by all Aps.net Controls
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (ViewState["vsNum"] == null)
                {
                    ViewState["vsNum"] = 0;
                }
                txtNum.Text = ViewState["vsNum"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clicksCount = (int)ViewState["vsNum"] + 1;
            txtNum.Text = clicksCount.ToString();
            ViewState["vsNum"] = clicksCount;

        }
    }
}