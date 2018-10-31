using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Business;

namespace Inventory.Presentation
{
    public partial class NewLeader : System.Web.UI.Page
    {
        //public List<Leader> leader
        //{
        //    get
        //    {
        //        if (Session["Lea"] == null)
        //        {
        //            Session["lea"] = new List<Leader>();
        //        }
        //        return (List<Leader>)Session["lea"];
        //    }
        //    set { Session["lea"] = value; }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlWorkingDay.DataSource = Enum.GetValues(typeof(workingDay));
                ddlJob.DataSource = Enum.GetValues(typeof(job));
                ddlWorkingDay.DataBind();
                ddlJob.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    Leader lea = new Leader()
                    {
                        Rut = int.Parse(txtRut.Text),
                        Dv = txtDV.Text,
                        Name = txtName.Text,
                        WorkingDay = (workingDay)ddlWorkingDay.SelectedIndex,
                        Carrera = txtCarrera.Text,
                        Job = (job)ddlJob.SelectedIndex
                    };
                    if (lea.Create())
                    {
                        Clear();
                        lblCrear.Text = "objeto creado";
                    }
                    else
                    {
                        lblCrear.Text = "objeto no creado";
                    }


                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo ingresar un nuevo integrante" + ex.Message);
            }
        }

        private void Clear()
        {
            txtName.Text = "";
            txtRut.Text = "";
            txtDV.Text = "";
            txtCarrera.Text = "";
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length <= 8; 
        }

        //protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        //{
        //    try
        //    {
        //        switch (args.Value)
        //        {
        //            case "1":
        //                args.IsValid = args.Value.CompareTo("1") == 0;
        //                break;
        //            case "2":
        //                args.IsValid = args.Value.CompareTo("2") == 0;
        //                break;
        //            case "3":
        //                args.IsValid = args.Value.CompareTo("3") == 0;
        //                break;
        //            case "4":
        //                args.IsValid = args.Value.CompareTo("4") == 0;
        //                break;
        //            case "5":
        //                args.IsValid = args.Value.CompareTo("5") == 0;
        //                break;
        //            case "6":
        //                args.IsValid = args.Value.CompareTo("6") == 0;
        //                break;
        //            case "7":
        //                args.IsValid = args.Value.CompareTo("7") == 0;
        //                break;
        //            case "8":
        //                args.IsValid = args.Value.CompareTo("8") == 0;
        //                break;
        //            case "9":
        //                args.IsValid = args.Value.CompareTo("9") == 0;
        //                break;
        //            case "0":
        //                args.IsValid = args.Value.CompareTo("0") == 0;
        //                break;
        //            case "k":
        //                args.IsValid = args.Value.CompareTo("k") == 0;
        //                break;
        //            case "K":
        //                args.IsValid = args.Value.CompareTo("K") == 0;
        //                break;
        //            default:

        //                break;
        //        }
        //    } catch (Exception ex)
        //    { 

        //    }
            
        //}
    }
}