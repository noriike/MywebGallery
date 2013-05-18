using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace MyWebGallery.samples.GridViewDetail
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.GetData();
        }

        /// <summary>
        /// データ取得
        /// </summary>
        private void GetData()
        {

            string s = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MyWebGallery.Properties.Settings.dbconstring"].ConnectionString;

            using(SqlConnection con=new SqlConnection(s)){
                con.Open();



            }
        }
    }
}