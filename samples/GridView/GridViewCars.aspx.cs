using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MywebGallery.resources.Data.car;

using System.Security.Principal;

namespace MyWebGallery.samples
{
    public partial class GridViewCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                this.Setup();
            }

        }

        private void Setup()
        {
            CarDao cardao = new CarDao();
            CarCollection carlst = cardao.Load();

            this.grdCars.DataSource = carlst;
            this.grdCars.DataBind();
        }

        protected void grdCars_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Object item = e.Row.DataItem;

                string url = "GridViewCarsPrint.aspx?" + "CarId=" + (string)DataBinder.Eval(item, "CarId");
                //e.Row.Cells[0].Attributes["onclick"] = "window.open("+"'" + url +"'" + ",'_blank'," + "'fullscreen=1,resizable=1'" + ")";
            }
           
        }

    

        protected void grdCars_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            string clientScript = "<script language='JavaScript'> window.open('GridViewCarsPrint.aspx','_blank','fullscreen=1,resizable=1'); </script>";

            //Page.RegisterClientScriptBlock("print", clientScript);

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "errMessage", clientScript, false);
        }

       

    }
}