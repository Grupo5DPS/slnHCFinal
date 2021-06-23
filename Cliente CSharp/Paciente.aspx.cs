using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_CSharp
{
    public partial class Escuela : System.Web.UI.Page
    {
        private srClinica.WebService1SoapClient servicio;
        private void Listar()
        {
            servicio = new srClinica.WebService1SoapClient();
            gvPaciente.DataSource = servicio.Listar();
            gvPaciente.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar();
            }

        }
 
        protected void Chart1_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            {
                try
                {
                    servicio = new srClinica.WebService1SoapClient();
                    gvPaciente.DataSource = servicio.Agregar(txtId.Text, txtNombre.Text, txtApellidos.Text, txtFechaNac.Text, txtSexo.Text, txtEstadoCivil.Text, txtOcupacion.Text, txtDireccion.Text, txtTelefono.Text);
                    gvPaciente.DataBind();
                }
                finally
                {
                    Listar();
                }


            }

        }
    }
}