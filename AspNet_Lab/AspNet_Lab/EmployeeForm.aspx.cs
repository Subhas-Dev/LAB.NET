using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace AspNet_Lab
{
    /* What is causing the duplication
     * All ASP.Net controls retain their state across postback. These controls make use of Viewstate. So the first time, when the web form load.the cities get correctly added to the drop down list and send back to the client.
     * 
     * Now when the client clicks the button control, and the webform is posted back to the server for procesing. 
     * During the page initialisation,viewstate restoration happens. During this stage, the city are retrieved 
     * from the viewstate and added to the Dropdown list.
     * 
     * PageLoad event happens later in the life cycle of the webform.During page load we are again adding another set of cities.
     * Hence duplication
     */
     //Using Javascript function, confirm and alert
    public partial class EmployeeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Using delete
            lnkDelete.Command += new CommandEventHandler(lnkDelete_Command);

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
            Response.Write("drpCity_SelectedIndexChanged :" + drpCity.SelectedIndex +"--"+ drpCity.SelectedValue + "<br>");

        }

        protected void rdoGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("rdoGender_SelectedIndexChanged :" + rdoGender.SelectedIndex + " - " + rdoGender.SelectedValue + "<br>");
        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            Response.Write("lnkDelete_Click Event" +"<br>");
        }

        protected void lnkDelete_Command(object sender, CommandEventArgs e)
        {
            Response.Write("lnkDelete_Command Event" + "<br>");
        }
    }
}