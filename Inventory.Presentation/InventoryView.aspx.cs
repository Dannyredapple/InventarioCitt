using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Business;

namespace Inventory.Presentation
{
    public partial class InventoryView : System.Web.UI.Page
    {
        //public List<Articule> articule
        //{
        //    get
        //    {
        //        if (Session["arti"] == null)
        //        {
        //            Session["arti"] = new List<Articule>();
        //        }
        //        return (List<Articule>)Session["arti"];
        //    }
        //    set { Session["arti"] = value; }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            //gvLista.DataSource = articule;
            //.DataBind();
            if (!IsPostBack)
            {
                LoadArticles();
            }
        }

        private void LoadArticles()
        {
            Collection col = new Collection();
            gvLista.DataSource =
            (
                from art in col.GetArticules()
                select new Articule
                {
                    ID = art.ID,
                    Name = art.Name,
                    Stock = art.Stock,
                    Description = art.Description,
                    Locker = (locker)Enum.Parse(typeof(locker),art.Locker.ToString())
                }
            ).ToList();
            gvLista.DataBind();
        }
    }
}