using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebGallery.samples.HttpResponse
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpRequest = null;
            HttpWebResponse myHttpResponse = null;
            string url = "http://localhost:57463/samples/HttpResponse/WebForm3.aspx";

            myHttpRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            myHttpRequest.Method = "GET";
            myHttpRequest.ContentType = "text/csv;encoding='UTF-8'";

            myHttpResponse =(HttpWebResponse) myHttpRequest.GetResponse();

          
        
            Stream stream=myHttpResponse.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            string html = reader.ReadToEnd();

            lblResponse.Text = html;
        }
    }

}