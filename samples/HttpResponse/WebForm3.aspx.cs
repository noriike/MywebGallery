using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace MyWebGallery.samples.HttpResponse
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("11,1,,aw,f");
            sb.Append("&nbsp;");
            sb.Append("11,1,,aw,f");
            sb.Append("&nbsp;");
            sb.Append("11,1,,aw,f");
            sb.Append("&nbsp;");

            Response.Write(sb.ToString());
        }
    }
}