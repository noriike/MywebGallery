using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Web.Configuration;
using System.Text;

namespace MyWebGallery.samples.FileUpload
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            this.FileSave();

        }

        private void FileSave()
        {

            string s = WebConfigurationManager.ConnectionStrings["MyWebGallery.Properties.Settings.dbconstring"].ConnectionString;

            using (SqlConnection con = new SqlConnection(s))
            {
                SqlCommand com = new SqlCommand("insert into datcarbin (binary) values(@binary)", con);
                con.Open();

                com.Parameters.AddWithValue("@binary", FileUpload1.FileBytes);

                com.ExecuteNonQuery();
            }

        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            string s = WebConfigurationManager.ConnectionStrings["MyWebGallery.Properties.Settings.dbconstring"].ConnectionString;

            byte[] img = null;

            using (SqlConnection con = new SqlConnection(s))
            {
                SqlCommand com = new SqlCommand("select binary from datcarbin where carbinid=@id", con);
                con.Open();

                com.Parameters.AddWithValue("@id", 4);

                img = (byte[])com.ExecuteScalar();
            }

            Response.BinaryWrite(img);
        }
    }
}