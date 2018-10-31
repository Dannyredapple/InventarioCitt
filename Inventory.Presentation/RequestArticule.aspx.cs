using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Business;

namespace Inventory.Presentation
{
    public partial class RequestArticule : System.Web.UI.Page
    {
        List<string> NamesArticules = new List<string>();
        List<string> NameLeaders = new List<string>();

      

        public List<Leader> leader
        {
            get
            {
                if (Session["Lea"] == null)
                {
                    Session["lea"] = new List<Leader>();
                }
                return (List<Leader>)Session["lea"];
            }
            set { Session["lea"] = value; }

        }


        public List<Articule> articule
        {
            get
            {
                if (Session["arti"] == null)
                {
                    Session["arti"] = new List<Articule>();
                }
                return (List<Articule>)Session["arti"];
            }
            set { Session["arti"] = value; }
        }

        public List<Request> request
        {
            get {
                if (Session["requ"] == null)
                {
                    Session["requ"] = new List<Request>();
                }
                return (List<Request>)Session["requ"]; }
            set { Session["requ"] = value; }
        }

        public Articule getArticuleById(string id)
        {
            return articule.First(a => a.ID == int.Parse(id));
        }

        public Leader getLeaderById(string name)
        {
            return leader.First(l => l.Name == name);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                txtDateToday.Text = date;
                lblDate.Text = date;
                Collection colArt = new Collection();
                ddlAticle.DataSource =
                (
                    from art in colArt.GetArticules()
                    select art.Name
                ).ToList();

                Collection colLead = new Collection();
                ddlAuthorized.DataSource =
                    (
                    from lead in colArt.GetLeaders()
                    select lead.Name
                    ).ToList();

                foreach (Leader le in leader)
                {
                    ddlAuthorized.Items.Add(new ListItem()
                    {
                        Text = le.Name,
                        Value = le.Name.ToString()
                    });
                }
                //foreach (Articule name in articule)
                //{
                //    NamesArticules.Add(name.Name);
                //}
                //foreach(Leader name in leader)
                //{
                //    NameLeaders.Add(name.Name);
                //}
                //ddlAuthorized.DataSource = NameLeaders;
                //ddlAuthorized.DataBind();
                //ddlAticle.DataSource = NamesArticules;
                ddlAticle.DataBind();
                ddlAuthorized.DataBind();
                gvRequest.DataSource = request;
                gvRequest.DataBind();
            }
        }





        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length < 41;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = int.Parse(args.Value) <= 50;
        }

        protected void txtDateToday_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    Request re = new Request()
                    {
                        Name = txtRequestedBy.Text,
                        Cant = int.Parse(txtQuantity.Text),
                        Email = txtEmail.Text,
                        articule = getArticuleById(ddlAticle.SelectedItem.Value),
                        leader = getLeaderById(ddlAuthorized.SelectedItem.Value)
                    };
                    request.Add(re);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede pedir articulo" + ex.Message);
            }
        }

        protected void gvRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvRequest.DataSource = request;
            gvRequest.DataBind();
        }
    }
}