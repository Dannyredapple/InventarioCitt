using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory.Presentation
{
    public partial class StartSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            try
            {
                if (txtLogin.Text == "admin" && txtPass.Text == "admin")
                {
                    Server.Transfer("index.aspx", true);
                }
            }
            catch(Exception ex)
            {
                message = "Error al Iniciar Session" + ex.Message;
            }
            lblCatch.Text = message;
            lblCatch.Visible = true;
        }
    }
}