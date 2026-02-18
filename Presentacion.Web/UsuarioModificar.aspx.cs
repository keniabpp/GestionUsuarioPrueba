using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Presentacion.Web.ServicioUsuario;

namespace Presentacion.Web
{
    public partial class UsuarioModificar : System.Web.UI.Page
    {

        private int Id
        {
            get => Convert.ToInt32(Request.QueryString["Id"]);
            set => ViewState["Id"] = value;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    Id = Convert.ToInt32(Request.QueryString["id"]);
                    CargarUsuario(Id);


                }
            }
        }

        private void CargarUsuario(int id)
        {
            using (UsuarioServiceClient servicio = new UsuarioServiceClient())
            {
                var usuario = servicio.Consultar().FirstOrDefault(x => x.Id == id);
                if (usuario != null)
                {
                    txtNombre.Text = usuario.Nombre;
                    txtFechaNacimiento.Text = usuario.FechaNacimiento.ToString("yyyy-MM-dd");
                    ddlSexo.SelectedValue = usuario.Sexo;
                }
            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Presentacion.Web.ServicioUsuario.Usuario usuario = new Presentacion.Web.ServicioUsuario.Usuario
                {
                    Id = Id,
                    Nombre = txtNombre.Text,
                    FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text),
                    Sexo = ddlSexo.SelectedValue
                };

                using (UsuarioServiceClient servicio = new UsuarioServiceClient())
                {
                    servicio.Modificar(usuario);
                    
                }

                lblMensaje.Text = "Usuario actualizado correctamente";
                Response.Redirect("UsuarioConsulta.aspx");
            }
        }

    }
}