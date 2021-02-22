using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet_Lab
{
    public partial class ViewState1 : System.Web.UI.Page
    {
        // Using view state variables to increment clicks count
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack) {
                //txtNum.Text = "0"; //opt 1
                if (ViewState["vsNum"] == null) 
                {
                    ViewState["vsNum"] = 0;
                }
                txtNum.Text = ViewState["vsNum"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //txtNum.Text = (int.Parse(txtNum.Text) + 1).ToString(); // opt 1

            //ViewState["vsNum"] = int.Parse(txtNum.Text) + 1;
            //txtNum.Text = ViewState["vsNum"].ToString();
            int clicksCount = (int)ViewState["vsNum"] + 1;
            txtNum.Text = clicksCount.ToString();
            ViewState["vsNum"] = clicksCount;

        }
    }
}