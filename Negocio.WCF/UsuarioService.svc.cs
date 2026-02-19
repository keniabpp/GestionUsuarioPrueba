using System;
using System.Collections.Generic;
using Negocio.WCF.DAL;
namespace Negocio.WCF
{
    
    public class UsuarioService : IUsuarioService
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        public void Agregar(Usuario usuario)
        {

            if (string.IsNullOrEmpty(usuario.Nombre))
                    throw new Exception("El nombre es obligatorio.");
            
            if (usuario.FechaNacimiento == DateTime.MinValue)
                    throw new Exception("La fecha de nacimiento es obligatoria.");
               
            if (string.IsNullOrEmpty(usuario.Sexo))
                    throw new Exception("El sexo es obligatorio.");

            usuarioDAL.Agregar(usuario);


        }

        public void Modificar(Usuario usuario)
        {
           usuarioDAL.Modificar(usuario);
        }

        public List<Usuario> Consultar()
        {
           return usuarioDAL.Consultar();
        }

        public void Eliminar(int id)
        {
            usuarioDAL.Eliminar(id);


        }

    }
}
