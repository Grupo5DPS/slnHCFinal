using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Intranet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        //private Hospital hospital = new Hospital;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.DataSource = servicio.ListarUsuarios();
            GridView2.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView2.DataSource = servicio.ListarUsuarios();
            GridView2.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView2.DataSource = servicio.ListarUsuarios();
            GridView2.DataBind();
        }
    }
}