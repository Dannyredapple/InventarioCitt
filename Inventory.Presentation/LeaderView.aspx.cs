using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Business;

namespace Inventory.Presentation
{
    public partial class LeaderView : System.Web.UI.Page
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
            if(!IsPostBack)
            {
                LoadLeader();
            }
        }

        private void LoadLeader()
        {
            Collection col = new Collection();
            gvLeader.DataSource =
            (
                from lea in col.GetLeaders()
                select new Leader
                {
                    Rut = lea.Rut,
                    Dv = lea.Dv,
                    Name = lea.Name,
                    WorkingDay = (workingDay)Enum.Parse(typeof(workingDay),lea.WorkingDay.ToString(),true),
                    Carrera = lea.Carrera,
                    Job = (job)Enum.Parse(typeof(job),lea.Job.ToString(),true)
                }
            ).ToList();
            gvLeader.DataBind();
        }



    }


}