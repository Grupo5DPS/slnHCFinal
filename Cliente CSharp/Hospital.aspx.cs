using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_CSharp
{
    public partial class Contact : Page
    {
        private srClinica.WebService1SoapClient servicio;
        private void Listar()
        {
            servicio = new srClinica.WebService1SoapClient();
            gvHospital.DataSource = servicio.ListarHo();
            gvHospital.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar();
            }

        }

        protected void gvHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    servicio = new srClinica.WebService1SoapClient();
                    gvHospital.DataSource = servicio.AgregarHo(txtId.Text, txtDescripcion.Text,txtDirector.Text, txtDireccion.Text,txtContacto.Text, txtCorreo.Text);
                    gvHospital.DataBind();
                }
                finally
                {
                    Listar();
                }


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    servicio = new srClinica.WebService1SoapClient();
                    gvHospital.DataSource = servicio.AgregarHo(txtId.Text, txtDescripcion.Text, txtDirector.Text, txtDireccion.Text, txtContacto.Text, txtCorreo.Text);
                    gvHospital.DataBind();
                }
                finally
                {
                    Listar();
                }


            }
        }
    }
}