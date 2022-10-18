using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Sneakers> sneakers = new List<Sneakers>();
                sneakers.Add(new Sneakers() { ShoeId = 1001, SneakerName = "Air Jordan High Shadow Toe", Type = "High" });
                sneakers.Add(new Sneakers() { ShoeId = 1002, SneakerName = "Air Jordan High Chicago Red", Type = "High" });
                sneakers.Add(new Sneakers() { ShoeId = 1003, SneakerName = "Air Jordan High Obsidian Blue", Type = "High" });
                ViewState["SneakerData"]=sneakers;

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (BlackShoe.Checked == true)
            {
                blackshoepic.Visible = true;
                redshoepic.Visible = false;
                blueshoepic.Visible = false;

            }
            
            else if(RedShoe.Checked == true)
            {
                redshoepic.Visible = true;
                blackshoepic.Visible = false;
                blueshoepic.Visible = false;
            }
            else
            {
                 blueshoepic.Visible = true;
                redshoepic.Visible = false;
                blackshoepic.Visible = false;
            }
            Session["Name"] = Name.Text;
            Session["Shoes"] = new List<string>() { "Shadow Toe", "Chicago Red", "Obsidian Blue" };

            //Create a Cookie
            HttpCookie cookie = new HttpCookie("RemindMe");
            cookie.Value = "To Attend Townhall Session";
            cookie.Expires=DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);

            //cookie for prefrences
            HttpCookie prefCookie = new HttpCookie("Preferences");
            prefCookie.Value = "AliceBlue:White"; //blue as bg, white as foreground
            Response.Cookies.Add(prefCookie);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.vegnonveg.com/footwear");
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ViewState["SneakerData"];
            GridView1.DataBind();
        }
    }
}