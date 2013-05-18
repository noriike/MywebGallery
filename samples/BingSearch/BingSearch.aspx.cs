using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Services.Client;
using System.Net;

namespace MyWebGallery.samples.BingSearch
{
    public partial class BingSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void SetUpPage()
        {
            
        }

        /// <summary>
        /// 検索ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {

            // This is the query - or you could get it from args.
            string query = txtSearch.Text.Trim();

            // Create a Bing container.
            string rootUri = "https://api.datamarket.azure.com/Bing/Search";
            var bingContainer = new Bing.BingSearchContainer(new Uri(rootUri));

            // Replace this value with your account key.
            var accountKey = "";

            // Configure bingContainer to use your credentials.
            bingContainer.Credentials = new NetworkCredential(accountKey, accountKey);

            // Build the query.
            if (rdbWeb.Checked)
            {
                var webQuery = bingContainer.Web(query, null, null, null, null, null, null, null);
                webQuery = webQuery.AddQueryOption("$top", 10);
                var webResults = webQuery.Execute();

               
                grdResult.DataSource = webResults;
                grdResult.DataBind();
            }
            else
            {
                var imageQuery = bingContainer.Image(query, null, null, null, null, null, null);
                var imageResults = imageQuery.Execute();
                grdResult.DataSource = imageResults;
                grdResult.DataBind();
            }
            
            

        }
    }
}