using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Presentacion.Web.ServicioUsuario;

namespace Presentacion.Web
{
    public partial class UsuarioConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarUsuarios();
            }

        }

        private void CargarUsuarios()
        {
            UsuarioServiceClient servicio = new UsuarioServiceClient();
            gvUsuarios.DataSource = servicio.Consultar();
            gvUsuarios.DataBind();
            servicio.Close();
        }

        protected void gvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Modificar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int id = Convert.ToInt32(gvUsuarios.DataKeys[index].Value);

                Response.Redirect("UsuarioModificar.aspx?id=" + id);
            }

            if (e.CommandName == "Eliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int id = Convert.ToInt32(gvUsuarios.DataKeys[index].Value);

                UsuarioServiceClient servicio = new UsuarioServiceClient();
                servicio.Eliminar(id);
                lblMensaje.Text = "Usuario eliminado correctamente";
                servicio.Close();
                

                CargarUsuarios(); 
                
            }
        }
    }
}