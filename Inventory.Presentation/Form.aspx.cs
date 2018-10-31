using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Business;

namespace Inventory.Presentation
{
    public partial class Form : System.Web.UI.Page
    {

        //public List<Articule> articule
        //{
        //    get {
        //        if (Session["arti"] == null)
        //        {
        //            Session["arti"] = new List<Articule>();
        //        }
        //        return (List<Articule>)Session["arti"];
        //        }
        //    set { Session["arti"] = value; }
        //}


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDrawer.DataSource = Enum.GetValues(typeof(locker));
                ddlDrawer.DataBind();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    
                    Articule ar = new Articule()
                    {
                        //ID = maxid + 1,
                        Name = txtName.Text,
                        Stock = int.Parse(txtStock.Text),
                        Description = txtName.Text,
                        Locker = (locker)ddlDrawer.SelectedIndex
                    };
                    if (ar.Create())
                    {
                        lblCrear.Text = "Se ha creado el articulo";
                        Clear();
                    }
                    else
                    {
                        lblCrear.Text = "La mierda no se creo";
                    }
                    
                }
            }
            catch (Exception ex)
            {
                lblCrear.Text=ex.Message;
            }
        }

        private void Clear()
        {
            txtName.Text = "";
            txtDesc.Text = "";
            txtStock.Text = "";
        }



        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length <= 30;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = int.Parse(args.Value) >= 0;
        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length <= 100;
        }

        protected void ddlDrawer_SelectedIndexChanged(object sender, EventArgs e)
        {
           // int algo = ddlDrawer.SelectedIndex;
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {

        }
    }
}