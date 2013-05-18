using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebGallery.samples.HttpHandler
{
    /// <summary>
    /// Handler1 の概要の説明です
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}