using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace MyWebGallery.samples.JavaScript
{
    public partial class CsharpToJavascript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 動的に.aspx側のjavascript呼び出しjavascript作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("<script type='text/JavaScript'>");
            sb.Append(" window.onload=calltest(");
            //sb.Append(this.Button2.ClientID);
            sb.Append(");");
            sb.Append(" </script>");

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clientcall", sb.ToString(), false);
         
            
        }

        /// <summary>
        /// javascript側からpostbackで呼び出される
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}