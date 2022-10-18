using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Professional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //connect to database
            SqlDataAdapter adaptor=new SqlDataAdapter();
            //get the command from SQLDataSource1
            adaptor.InsertCommand = new SqlCommand(SqlDataSource1.InsertCommand);
            adaptor.InsertCommand.Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KpmgDb;Integrated Security=True");



            //Add parameters for command
            adaptor.InsertCommand.Parameters.Add(new SqlParameter("Name", TextName.Text));
            adaptor.InsertCommand.Parameters.Add(new SqlParameter("Designation", TextDesg.Text));
            adaptor.InsertCommand.Parameters.Add(new SqlParameter("Salary", TextSalary.Text));
            //open connection //excute commands
            using (adaptor.InsertCommand.Connection) {
                adaptor.InsertCommand.Connection.Open();
                adaptor.InsertCommand.ExecuteNonQuery();
            }
            //re-bind the grid
            GridView1.DataBind();

            

        }
    }
}