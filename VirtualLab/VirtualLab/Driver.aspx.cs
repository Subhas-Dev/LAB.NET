using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualLab
{
    public partial class Driver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //drpCity.Items.Clear();
                drpCity.Items.Add(new ListItem("Milton"));
                drpCity.Items.Add("London");
                drpCity.Items.Add(new ListItem("Toronto"));
                drpCity.Items.Add("Waterloo");
                drpCity.Items.Add("Mississauga");
                chkDoctorate.Focus();
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // Btn register
            Response.Write("btnRegister_Click Event" + "<br>");

            StringBuilder sbChoices = new StringBuilder();
            if (chkGraduate.Checked)
            { sbChoices.Append("," + chkGraduate.Text); }

            if (chkPostGraduate.Checked)
            { sbChoices.Append("," + chkPostGraduate.Text); }
            if (chkDoctorate.Checked)
            { sbChoices.Append("," + chkDoctorate.Text); }
            Response.Write(sbChoices.ToString() + "<br>");
        }

        protected void drpCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // drpCity_SelectedIndexChanged
            Response.Write("drpCity_SelectedIndexChanged :" + drpCity.SelectedIndex + "--" + drpCity.SelectedValue + "<br>");

        }

        protected void rdoGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //rdoGender_SelectedIndexChanged
            Response.Write("rdoGender_SelectedIndexChanged :" + rdoGender.SelectedIndex + " - " + rdoGender.SelectedValue + "<br>");
        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            //lnkDelete_Click
            Response.Write("lnkDelete_Click Event" + "<br>");
        }

        protected void lnkDelete_Command(object sender, CommandEventArgs e)
        {
            //lnkDelete_Command
            Response.Write("lnkDelete_Command Event" + "<br>");
        }

    }
}