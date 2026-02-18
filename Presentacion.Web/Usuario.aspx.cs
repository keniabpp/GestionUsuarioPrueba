using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Presentacion.Web.ServicioUsuario;

namespace Presentacion.Web
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                UsuarioServiceClient servicio = new UsuarioServiceClient();
                ServicioUsuario.Usuario usuario = new ServicioUsuario.Usuario();
                {
                    usuario.Nombre = txtNombre.Text;
                    usuario.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                    usuario.Sexo = ddlSexo.SelectedValue;

                    servicio.Agregar(usuario);
                    servicio.Close();

                    lblMensaje.Text = "Usuario creado correctamente";
                    Response.Redirect("UsuarioConsulta.aspx");


                }
                ;
            }
        }
        

        
    }
}