using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "You have come as:  "+ Convert.ToString(Session["Name"]);
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelected.Text = "Your selected Value: " + ListBox1.SelectedValue.ToString();
            lblSelected.Text = lblSelected.Text + "| your selected text: " + ListBox1.SelectedItem.Text;

        }
        protected void Button2_Click(object sender,EventArgs e)
        {
            List<string> dataFromSession = (List<string>)Session["Shoes"];
            ListBox2.DataSource = dataFromSession;
            ListBox2.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie varReadCookie= Request.Cookies["RemindMe"];
            Button3.Text = varReadCookie.Value;

            HttpCookie varPrefCookie = Request.Cookies["Preferences"];
            string cookieValue = varPrefCookie.Value;
            string[] splits = cookieValue.Split(':');

            ApplyColor(splits[0], "BackColor");
            ApplyColor(splits[1], "ForeColor");

        }
        private void ApplyColor(string color, string property)
        {
            System.Drawing.Color resultColor = System.Drawing.Color.White;
            switch (color)
            {
                case "CadetBlue":
                    resultColor= System.Drawing.Color.CadetBlue;
                    break;

                case "White":
                    resultColor = System.Drawing.Color.White;
                    break;
                
                default:
                    resultColor = System.Drawing.Color.Tomato;
                    break;
            }
            if (property == "BackColor")
            {
                ListBox1.BackColor = resultColor;
                ListBox2.BackColor = resultColor;
            }
            else if(property == "ForeColor")
            {
                ListBox1.ForeColor = resultColor;
                ListBox2.ForeColor = resultColor;
            }
        }
    }
}