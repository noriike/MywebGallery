using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MywebGallery.resources.Data.car;

namespace MyWebGallery.samples.Ajax
{
    public partial class PopUp : System.Web.UI.Page
    {
        public CarCollection carcollection
        {
            get
            {
                return (CarCollection)this.ViewState["CARCOLLECTION"];
            }

            set
            {
                this.ViewState["CARCOLLECTION"] = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Setuppage();
            }
        }

        private void Setuppage()
        {
            CarCollection carlst = new CarCollection();
            CarDao cardao = new CarDao();
            carlst = cardao.Load();

            //ComboBox1.DataTextField = "Name";

            for (int i = 0; i < 500; i++)
            {

                foreach (Car item in carlst)
                {

                    lstCars.Items.Add(new ListItem(item.Name, item.CarId));
                    //ComboBox1.Items.Add(new ListItem(item.Name, item.CarId));
                }
            }

            //ObjectDataSource ods = new ObjectDataSource("CarDao", "Load");

            //ComboBox1.DataTextField = "Name";
            //ComboBox1.DataValueField = "CarId";
            //ComboBox1.DataSource = this.carcollection;

            this.carcollection = carlst;
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {
            //CarCollection carlst = this.carcollection;

            //String txt = ((TextBox)sender).Text;

            //lstCars.Items.FindByText(txt);

            
        }

        protected void ComboBox1_ItemInserted(object sender, AjaxControlToolkit.ComboBoxItemInsertEventArgs e)
        {

        }

        protected void txtCarId_TextChanged(object sender, EventArgs e)
        {
            String s = ((TextBox)sender).Text;
            CarCollection carlst = this.carcollection;

            if (char.IsDigit(s,0))//数字なら
            {
                if (carlst.FindIndex(c => c.CarId == s) != -1)//このコードがヒットするか
                {
                    lblCarName.Text = carlst.Find(c => c.CarId == s).Name;
                }
                else
                {
                    lblCarName.Text = string.Empty;
                    txtCarId.Text = string.Empty;
                }
            }
            else//文字なら
            {

            }

        }
    }
}